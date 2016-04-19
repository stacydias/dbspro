using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dbspro
{
	public partial class Sign_Up : Form
    {
        Login frm1 = new Login();
       
 
		public Sign_Up()
		{
			InitializeComponent();
		}

	
       

     
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            try {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=password";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query2 = "insert into collegefest.student(student_id,name,phone_no,email,semester) values ('" +this.textBox1.Text + "','" + this.textBox3.Text + "','" + this.textBox6.Text + "','"+ this.textBox4.Text +"','"+ Convert.ToInt32(this.comboBox1.SelectedValue)+"');";

                string Query1 = "insert into collegefest.user(student_id, password) values('"+ this.textBox1.Text+"','"+this.textBox2.Text+"');";                                                                                                                                       //This is  MySqlConnection here i have created the object and pass my connection string.  
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //This is command class which will handle the query and connection object.  
            MySqlCommand MyCommand2 = new MySqlCommand(Query1, MyConn2);
                MySqlCommand MyCommand3 = new MySqlCommand(Query2, MyConn2);
                MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                                                        //MessageBox.Show("Save Data");
            while (MyReader2.Read())
            {
               
            }
                MyReader2.Close();

                MyReader2 = MyCommand3.ExecuteReader();

              

                while (MyReader2.Read())
                {

                }
                MyConn2.Close();
        }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }






//string first_name = textBox1.
MessageBox.Show("Registration Successful");
            this.Hide();
            frm1.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frm1.Show();
        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
