using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbspro
{
    public partial class ParticipantForm : Form
    {
        string prtid;
        private Categories ctg = new Categories();
        public ParticipantForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
           // ctg.Show();

            if (prtid == null)
                MessageBox.Show("Cannot proceed without entering Participant ID");

            else
            {

                string query = "Select * from table where prtid = \"" + prtid + "\"";
                Categories f2 = new Categories();
                f2.Show();
                this.Hide();
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            prtid = prtidtextbox.Text;
        }
    }
}
