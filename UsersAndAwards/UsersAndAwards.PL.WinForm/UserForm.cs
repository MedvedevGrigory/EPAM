using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsersAndAwards.PL.WinForm
{
    public partial class UserForm : Form
    {
        public string FirstName
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }

        public string LastName
        {
            get => textBox2.Text;
            set => textBox2.Text = value;
        }

        public DateTime Birthdate
        {
            get => dateTimePicker1.Value;
            set => dateTimePicker1.Value = value;
        }

        public List<Award> Awards
        {
            get
            {
                return checkedListBox1.CheckedItems.Cast<Award>().ToList();
            }
        }

        public UserForm(IEnumerable<Award> awards, User user = null)
        {
            InitializeComponent();

            foreach (Award award in awards)
            {
                bool isCheck = user is null ? false : user.Awards.Any(a => a.ID == award.ID);
                checkedListBox1.Items.Add(award, isCheck);
            }

            if (user != null)
            {
                FirstName = user.FirstName;
                LastName = user.LastName;
                Birthdate = user.Birthdate;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
