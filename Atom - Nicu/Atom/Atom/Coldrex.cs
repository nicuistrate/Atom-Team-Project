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
    public partial class Coldrex : Form
    {
        public Coldrex()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool found = false;
            Data data = new Data();
            PharmacyData db = new PharmacyData();
            IQueryable<Medicament> medsList = from b in db.Medicaments
                                              orderby b.Id
                                              select b;
            List<Medicament> medicaments = medsList.ToList();
            foreach (Medicament medicament in medicaments)
            {
                if (medicament.MedName == "Coldrex" && medicament.MedQuantity > 0)
                {
                    Data.ColdrexQuantity++;
                    //medicament.MedQuantity--;
                    found = true;
                    //db.SaveChanges();
                }
            }
            if (found == false)
            {
                this.Hide();
                Form notFound = new MedicamentInsuficient();
                notFound.Show();
            }
            else
            {
                this.Hide();
                Form bought = new ProductBought();
                bought.Show();
            }
        }
    }
}
