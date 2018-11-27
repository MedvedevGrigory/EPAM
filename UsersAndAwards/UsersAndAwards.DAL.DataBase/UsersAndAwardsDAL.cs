using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace UsersAndAwards.DAL
{
    public class UsersAndAwardsDAL : IUsersAndAwarsDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

        public void AddAward(Award award)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "AddAward";
                    command.Parameters.AddWithValue("@title", award.Title);
                    command.Parameters.AddWithValue("@description", award.Description);

                    command.Connection = connection;
                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "AddUser";
                    command.Parameters.AddWithValue("@firstName", user.FirstName);
                    command.Parameters.AddWithValue("@lastName", user.LastName);
                    command.Parameters.AddWithValue("@birthdate", user.Birthdate);

                    command.Connection = connection;
                    connection.Open();

                    int id = (int)command.ExecuteScalar();
                    user.ID = id;
                    connection.Close();
                }

                foreach (Award award in user.Awards)
                {
                    AddAwardOfUser(connection, user.ID, award.ID);
                }
            }
        }

        private void AddAwardOfUser(SqlConnection connection, int userId, int awardId)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "AddAwardOfUser";
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@awardId", awardId);

                command.Connection = connection;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void DeleteAward(int ID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DeleteAwardsFromUser(ID, connection);

                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "DeleteAward";
                    command.Parameters.AddWithValue("@id", ID);
                    command.Connection = connection;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteUser(int ID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DeleteAwardsFromUser(ID, connection);

                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "DeleteUser";
                    command.Parameters.AddWithValue("@id", ID);
                    command.Connection = connection;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Award> GetAllAwards()
        {
            List<Award> awards = new List<Award>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "GetAllAwards";
                    command.Connection = connection;

                    connection.Open();
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string title = reader.GetString(1);
                        string description = reader.GetString(2);

                        awards.Add(new Award(title, description, id));
                    }
                }
            }

            return awards;
        }

        public IEnumerable<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            IEnumerable<Award> awards = GetAllAwards();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "GetAllUser";
                    command.Connection = connection;

                    connection.Open();
                    var reader = command.ExecuteReader();

                    while(reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string firstName = reader.GetString(1);
                        string lastName = reader.GetString(2);
                        DateTime birthdate = reader.GetDateTime(3);

                        users.Add(new User(firstName, lastName, birthdate, id));
                    }

                    connection.Close();
                }

                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "GetAwardsOfUsers";
                    command.Connection = connection;

                    connection.Open();
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int userId = reader.GetInt32(0);
                        int awardID = reader.GetInt32(1);

                        users.First(user => user.ID == userId).Awards.Add(awards.First(award => award.ID == awardID));
                    }
                }
            }

            return users;
        }

        public void UpdateAward(Award award)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "UpdateAward";
                    command.Parameters.AddWithValue("@id", award.ID);
                    command.Parameters.AddWithValue("@title", award.Title);
                    command.Parameters.AddWithValue("@description", award.Description);

                    command.Connection = connection;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void UpdateUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "UpdateUser";
                    command.Parameters.AddWithValue("@id", user.ID);
                    command.Parameters.AddWithValue("@firstName", user.FirstName);
                    command.Parameters.AddWithValue("@lastName", user.LastName);
                    command.Parameters.AddWithValue("@birthdate", user.Birthdate);

                    command.Connection = connection;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                DeleteAwardsFromUser(user.ID, connection);

                foreach (Award award in user.Awards)
                {
                    AddAwardOfUser(connection, user.ID, award.ID);
                }
            }
        }

        private static void DeleteAwardsFromUser(int id, SqlConnection connection)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DeleteAwardsFromUser";
                command.Parameters.AddWithValue("@id", id);

                command.Connection = connection;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
