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
    public partial class MainForm : Form
    {
        public MainForm(string v)
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (numeMedicamentBox.Text != null && numeOrasBox.Text != null && !string.IsNullOrWhiteSpace(numeMedicamentBox.Text) && !string.IsNullOrWhiteSpace(numeOrasBox.Text))
            {
                PharmacyData db = new PharmacyData();
                IQueryable<Medicament> medsList = from b in db.Medicaments
                                                  orderby b.Id
                                                  select b;

                List<Medicament> medicaments = medsList.ToList();
                foreach (Medicament medicament in medicaments)
                {
                    if (medicament.MedName == numeMedicamentBox.Text)
                    {
                        if (medicament.MedName == "Paracetamol" && numeOrasBox.Text == "Cluj")
                        {
                            this.Hide();
                            Form paracetamol = new Paracetamol();
                            paracetamol.Show();
                        }

                        else if (medicament.MedName == "Vitamine" && numeOrasBox.Text == "Timisoara")
                        {
                            this.Hide();
                            Form vitamine = new Vitamine();
                            vitamine.Show();
                        }

                        else if (medicament.MedName == "Algocalmin" && numeOrasBox.Text == "Brasov")
                        {
                            this.Hide();
                            Form algocalmin = new Algocalmin();
                            algocalmin.Show();
                        }

                        else if (medicament.MedName == "Coldrex" && numeOrasBox.Text == "Bucuresti")
                        {
                            this.Hide();
                            Form coldrex = new Coldrex();
                            coldrex.Show();
                        }

                        else
                        {
                            this.Hide();
                            Form notFound = new MedNotFound();
                            notFound.Show();
                        }
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form cosCumparaturi = new CosCumparaturi();
            cosCumparaturi.Show();
        }
    }
}
