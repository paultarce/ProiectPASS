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

        List<Studenti> clientStudenti = new List<Studenti>();
        DataSourceFactory dsFactory;
        IStudentRepository studentRepository;

        string DataSource;

        public Form1(string DataSource)
        {
            InitializeComponent();
            this.DataSource = DataSource;
            lblDataSource.Text = "Data Source: " + DataSource;
        }

        private void btnAnulare_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            studentRepository = DataSourceFactory.getDataSource(DataSource);
            clientStudenti = studentRepository.GetAllStudents();

            txtNrMatricol.Text = "0";
            txtMedia.Text = txtNume.Text = "";
            btnStergere.Enabled = false;
            btnSalvare.Text = "Inserare";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Clear();
            PopulateDataGridView();
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {

            Studenti student = new Studenti();
            student.NrMatricol = Convert.ToInt32(txtNrMatricol.Text);
            student.Nume = txtNume.Text;
            student.Medie = double.Parse(txtMedia.Text);

            if (btnSalvare.Text == "Inserare") // insert
            {
                studentRepository.InserareStudent(student);
            }
            else
            {
                studentRepository.ActualizeazaStudent(student);
            }
           
            Clear();
            PopulateDataGridView();
            MessageBox.Show("Submitteed Successfully");

        }


        void PopulateDataGridView() //get Studenti from Student Repo 
        {
            /*dataGridView1.AutoGenerateColumns = false;
            using (PassDBEntities db = new PassDBEntities())
            {
                dataGridView1.DataSource = db.Studenti.ToList<Studenti>();
            }*/

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = studentRepository.GetAllStudents();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        Studenti selectedStudent;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
            if (dataGridView1.CurrentRow.Index != -1)
            {
                selectedStudent = new Studenti() { NrMatricol = Convert.ToInt32(dataGridView1.CurrentRow.Cells["NrMatricol"].Value) };

                selectedStudent = studentRepository.GetAllStudents().Where(s => s.NrMatricol == selectedStudent.NrMatricol).FirstOrDefault();

                txtNrMatricol.Text = selectedStudent.NrMatricol.ToString();
                txtNume.Text = selectedStudent.Nume;
                txtMedia.Text = selectedStudent.Medie.ToString();

                btnSalvare.Text = "Actualizare";
                btnStergere.Enabled = true;
            }

        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            studentRepository.StergereStudent(selectedStudent);

            Clear();
            PopulateDataGridView();

            MessageBox.Show("Deleted succesfully");
        }

        private void btnZiBuna_Click(object sender, EventArgs e)
        {
            if(txtNrMatricol.Text != "")
            {

            }
        }

        private void btnMedieViitor_Click(object sender, EventArgs e)
        {
            if (txtNrMatricol.Text != "")
            {

            }
        }

        private void btnPesteOpt_Click(object sender, EventArgs e)
        {

        }
    }
}
