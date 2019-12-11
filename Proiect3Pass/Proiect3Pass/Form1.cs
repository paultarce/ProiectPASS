using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect3Pass
{
    public partial class Form1 : Form
    {

        Studenti model = new Studenti();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnulare_Click(object sender, EventArgs e)
        {
            


        }

        void Clear()
        {
            txtNrMatricol.Text = "0";
            txtMedia.Text = txtNume.Text = "";
            btnStergere.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            model.NrMatricol = Convert.ToInt32(txtNrMatricol.Text);
            model.Nume = txtNume.Text;
            model.Medie = double.Parse(txtMedia.Text);

            using (PassDBEntities db = new PassDBEntities())
            {
                db.Studenti.Add(model);
                db.SaveChanges();
               
            }
            Clear();
            PopulateDataGridView();
            MessageBox.Show("Submitteed Successfully");



        }

        void PopulateDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (PassDBEntities db = new PassDBEntities())
            {
                dataGridView1.DataSource = db.Studenti.ToList<Studenti>();
            }
        }
    }
}
