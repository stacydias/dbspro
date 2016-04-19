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
	public partial class User : Form
	{
       // private User us = new User();
        private CatHeadForm chf = new CatHeadForm();
        private OrganiserForm org = new OrganiserForm();
        private ParticipantForm prt = new ParticipantForm();

		public User()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
            this.Hide();
            prt.ShowDialog();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
            org.ShowDialog();
		}

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            chf.ShowDialog();

        }

        private void User_Load(object sender, EventArgs e)
        {

        }
	}
}
