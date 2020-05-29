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
    public partial class LoginError : Form
    {
        public LoginError()
        {
            InitializeComponent();
        }

        private void LoginError_Load(object sender, EventArgs e)
        {

        }

        private void inapoiButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form1 = new Form1();
            form1.Show();
        }
    }
}
