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
	public partial class Login : Form
	{

		//private Form1 f1= new Form1();
         
		
        
        string username;
        string password;
		public Login()
		{
			InitializeComponent();
		}

	

		private void button2_Click(object sender, EventArgs e)
		{

			Application.Exit();

		}

		

       

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            if (username == null || password == null)
                MessageBox.Show("Cannot login if username or password field is empty");
            else if  (textBox2.Text.Length < 6)
                    MessageBox.Show("Password must be atleast 6-10 characters in length.");

                else
            {

                try
                {
                    int count = 0;
                    //This is my connection string i have assigned the database file address path  
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=password";
                    //This is my insert query in which i am taking input from the user through windows forms
                    string Query = "(SELECT COUNT(*) AS total FROM collegefest.user where student_id ='" + textBox1.Text + "' and password='" + textBox2.Text + "');";// and Password = ' " + textBox2.Text + " ')";
                                                                                                                                                                //This is  MySqlConnection here i have created the object and pass my connection string.  
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    //This is command class which will handle the query and connection object.  
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                                                                //MessageBox.Show("Save Data");
                    while (MyReader2.Read())
                    {
                        count = MyReader2.GetInt32("total");
                    }
                    if (count == 0)
                    {
                        MessageBox.Show("Incorrect ID or Password");
                        return;
                    }
                    else
                    {
                        User us = new User();
                        us.Show();
                        this.Hide();
                        //textBox2.Text = count.ToString();
                    }
                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                

               
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            username = textBox1.Text;
        }

      

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up su = new Sign_Up();
            su.Show();
            this.Hide();
            //this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
         
           
        }
    }
}
