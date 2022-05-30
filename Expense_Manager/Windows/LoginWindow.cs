using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Manager
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        public int LoggedUser { get; set; }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            using var context = new DataContext();
            if (context.Users == null)
            {
                throw new Exception("No users in database");
            }
            var user = context.Users.Where(u => u.Username == UsernameBox.Text && u.Password == PasswordBox.Text).FirstOrDefault();
            if (user != null)
            {
                LoggedUser = user.Id;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }

        }

        private void LoginWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void ManageAppUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageAppUsers users = new();
            users.Show();
        }

    }
}
