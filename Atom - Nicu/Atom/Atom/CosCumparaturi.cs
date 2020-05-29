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
    public partial class CosCumparaturi : Form
    {
        public bool check = false;
        public CosCumparaturi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                ListViewItem listViewItem1 = new ListViewItem("Paracetamol");
                listViewItem1.SubItems.Add(Data.ParacetamolQuantity.ToString());
                listView1.Items.Add(listViewItem1);

                ListViewItem listViewItem2 = new ListViewItem("Coldrex");
                listViewItem2.SubItems.Add(Data.ColdrexQuantity.ToString());
                listView1.Items.Add(listViewItem2);

                ListViewItem listViewItem3 = new ListViewItem("Algocalmin");
                listViewItem3.SubItems.Add(Data.AlgocalminQuantity.ToString());
                listView1.Items.Add(listViewItem3);

                ListViewItem listViewItem4 = new ListViewItem("Vitamine");
                listViewItem4.SubItems.Add(Data.VitamineQuantity.ToString());
                listView1.Items.Add(listViewItem4);
                check = true;
            }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data.ParacetamolQuantity = 0;
            Data.AlgocalminQuantity = 0;
            Data.ColdrexQuantity = 0;
            Data.VitamineQuantity = 0;
            this.Hide();
            Form cosCumparaturi = new CosCumparaturi();
            cosCumparaturi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PharmacyData db = new PharmacyData();
            IQueryable<Medicament> medsList = from b in db.Medicaments
                                              orderby b.Id
                                              select b;
            List<Medicament> medicaments = medsList.ToList();
            foreach (Medicament medicament in medicaments)
            {
                if (medicament.MedName == "Paracetamol")
                {
                    medicament.MedQuantity = medicament.MedQuantity - Data.ParacetamolQuantity;
                }
                if (medicament.MedName == "Algocalmin")
                {
                    medicament.MedQuantity = medicament.MedQuantity - Data.AlgocalminQuantity;
                }
                if (medicament.MedName == "Coldrex")
                {
                    medicament.MedQuantity = medicament.MedQuantity - Data.ColdrexQuantity;
                }
                if (medicament.MedName == "Vitamine")
                {
                    medicament.MedQuantity = medicament.MedQuantity - Data.VitamineQuantity;
                }
            }
            db.SaveChanges();
            Data.ParacetamolQuantity = 0;
            Data.AlgocalminQuantity = 0;
            Data.ColdrexQuantity = 0;
            Data.VitamineQuantity = 0;
            this.Hide();
            Form comanda = new ComandaFinalizata();
            comanda.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form MainForm = new MainForm(Convert.ToString(null));
            MainForm.Show();
        }
    }
}
