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
    public partial class MedicamentInsuficient : Form
    {
        public MedicamentInsuficient()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form MainForm = new MainForm(Convert.ToString(null));
            MainForm.Show();
        }
    }
}
