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
    public partial class QuestionForm : Form
    {
        public QuestionForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public string DataSource;
        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            DataSource = comboBox1.SelectedItem.ToString();

            Form1 form1 = new Form1(DataSource);
            this.Visible = false;

            form1.ShowDialog();
            
        }


    }
}
