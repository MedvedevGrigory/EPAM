using Entities;
using System;
using System.Windows.Forms;
using UsersAndAwards.BLL;

namespace UsersAndAwards.PL.WinForm
{
    public partial class MainForm : Form
    {
        IUsersAndAwardsBL usersAndAwards = new UsersAndAwardsBL();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateUserList();
            UpdateAwardList();
        }

        private void UpdateAwardList()
        {
            dataGridViewAwards.DataSource = null;
            dataGridViewAwards.DataSource = usersAndAwards.GetAllAwards();
        }

        private void UpdateUserList()
        {
            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = usersAndAwards.GetAllUsers();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm changeUser = new UserForm(usersAndAwards.GetAllAwards());
            if (changeUser.ShowDialog() == DialogResult.OK)
            {
                User user = new User(changeUser.FirstName, changeUser.LastName, changeUser.Birthdate)
                {
                    Awards = changeUser.Awards
                };
                usersAndAwards.AddUser(user);
                UpdateUserList();
                UpdateAwardList();
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User user = (User)dataGridViewUsers.SelectedRows[0].DataBoundItem;
            UserForm changeUser = new UserForm(usersAndAwards.GetAllAwards(), user);

            if (changeUser.ShowDialog() == DialogResult.OK)
            {
                user.FirstName = changeUser.FirstName;
                user.LastName = changeUser.LastName;
                user.Birthdate = changeUser.Birthdate;
                user.Awards = changeUser.Awards;

                usersAndAwards.UpdateUser(user);
                UpdateUserList();
                UpdateAwardList();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User user = (User)dataGridViewUsers.SelectedRows[0].DataBoundItem;
            usersAndAwards.DeleteUser(user.ID);
            UpdateUserList();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUserList();
            UpdateAwardList();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AwardForm changeAward = new AwardForm();
            if (changeAward.ShowDialog() == DialogResult.OK)
            {
                Award award = new Award(changeAward.Title, changeAward.Description);
                usersAndAwards.AddAward(award);

                UpdateUserList();
                UpdateAwardList();
            }
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Award award = (Award)dataGridViewAwards.SelectedRows[0].DataBoundItem;
            AwardForm changeAward = new AwardForm(award);

            if (changeAward.ShowDialog() == DialogResult.OK)
            {
                award.Title = changeAward.Title;
                award.Description = changeAward.Description;

                usersAndAwards.UpdateAward(award);

                UpdateUserList();
                UpdateAwardList();
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Award award = (Award)dataGridViewAwards.SelectedRows[0].DataBoundItem;
            usersAndAwards.DeleteAward(award.ID);
            UpdateAwardList();
        }
    }
}
