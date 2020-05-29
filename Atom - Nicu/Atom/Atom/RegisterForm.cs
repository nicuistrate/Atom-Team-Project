using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atom
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            /*if (usernameBox.Text != null && passwordBox.Text != null && confirmPasswordBox.Text != null &&!string.IsNullOrWhiteSpace(usernameBox.Text) && !string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                if (passwordBox.Text == confirmPasswordBox.Text && passwordBox.Text != null && !string.IsNullOrWhiteSpace(passwordBox.Text))
                {
                    /*var db = new PharmacyData();
                    TbUser tbUser = new TbUser();
                    tbUser.Username = usernameBox.Text;
                    tbUser.Password = passwordBox.Text;
                    db.TbUsers.Add(tbUser);
                    db.SaveChanges();
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
                                
                            }
                        }
                    }
                }
            }*/
            bool found = false;
            if (usernameBox.Text != null && passwordBox.Text != null && confirmPasswordBox.Text != null && !string.IsNullOrWhiteSpace(usernameBox.Text) && !string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                PharmacyData db = new PharmacyData();
                IQueryable<TbUser> tbUsersList = from b in db.TbUsers
                                                 orderby b.Id
                                                 select b;
                List<TbUser> tbUsers = tbUsersList.ToList();

                foreach (TbUser tbUser in tbUsers)
                {
                    if (tbUser.Username == usernameBox.Text && !string.IsNullOrWhiteSpace(usernameBox.Text))
                    {
                        found = true;
                        MessageBox.Show("User already exists!");
                    }
                }
            }
            if (found == false)
            {
                if (passwordBox.Text == confirmPasswordBox.Text && passwordBox.Text != null && !string.IsNullOrWhiteSpace(passwordBox.Text))
                {
                    var db = new PharmacyData();
                    TbUser tbUser = new TbUser();
                    tbUser.Username = usernameBox.Text;
                    tbUser.Password = passwordBox.Text;
                    db.TbUsers.Add(tbUser);
                    db.SaveChanges();
                }
            }

        }

        private void inapoiButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form1 = new Form1();
            form1.Show();
        }
    }
}
