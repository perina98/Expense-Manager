using Expense_Manager.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class ManageAppUsers : Form
    {
        public ManageAppUsers()
        {
            InitializeComponent();
            db = new DataContext();
        }

        DataContext db;

        private void AddAppUser_Click(object sender, EventArgs e)
        {
            if (UsernameBox.Text == "" || PasswordBox.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            if (db.Users == null)
            {
                throw new Exception("Database not ready for adding users");
            }
            if (db.Users.Where(x => x.Username == UsernameBox.Text).Any())
            {
                MessageBox.Show("Username already exists");
                return;
            }
            var user = new User
            {
                Username = UsernameBox.Text,
                Password = PasswordBox.Text
            };
            
            db.Users.Add(user);
            db.SaveChanges();
            MessageBox.Show("User added successfully");

            UsersTable.Refresh();   
        }
        
        private void ManageAppUsers_Load(object sender, EventArgs e)
        {
            if (db.Users == null)
            {
                throw new Exception("Database not ready");
            }
            db.Users.Load();
            userBindingSource.DataSource = db.Users.Local.ToBindingList();

            UsersTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void UsersTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (UsersTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
            
            if (db != null)
            {
                
                UsersTable.EndEdit();
                db.SaveChanges();
            }
        }

        private void RemoveUsers_Click(object sender, EventArgs e)
        {
            if (db.Users == null)
            {
                throw new Exception("Database not ready for removing users");
            }
            foreach (DataGridViewRow row in UsersTable.SelectedRows)
            {
                db.Users.Remove((User)row.DataBoundItem);
            }

            db.SaveChanges();
            UsersTable.Update();
            UsersTable.Refresh();
        }
    }
}
