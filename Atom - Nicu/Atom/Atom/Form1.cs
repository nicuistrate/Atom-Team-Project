using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Atom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Form registerForm = new RegisterForm();
            this.Hide();
            registerForm.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool logged = false;
            PharmacyData db = new PharmacyData();
            IQueryable<TbUser> tbUsersList = from b in db.TbUsers
                                             orderby b.Id
                                             select b;
            List<TbUser> tbUsers = tbUsersList.ToList();

            foreach (TbUser tbUser in tbUsers)
            {
                if (tbUser.Username == usernameBox.Text && !string.IsNullOrWhiteSpace(usernameBox.Text))
                {
                    if (tbUser.Password == passwordBox.Text && !string.IsNullOrWhiteSpace(passwordBox.Text))
                    {
                        this.Hide();
                        Form MainForm = new MainForm(Convert.ToString(usernameBox.Text));
                        MainForm.Show();
                        logged = true;
                    }
                }
            }
            if (logged == false)
            {
                this.Hide();
                Form LoginError = new LoginError();
                LoginError.Show();
            }

        }
    }
}
