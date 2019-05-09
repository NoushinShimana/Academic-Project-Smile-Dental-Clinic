using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class Patient_Information_Page : Form
    {
        DataAccess dt;
        public Patient_Information_Page()
        {

            InitializeComponent();
            dt = new DataAccess();
            DisplayData();
        }



        private void Button1_Click(object sender, EventArgs e)
        {


            if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                dt.comm.CommandText = "insert into patient(pat_id,name,age,disease,address,doc_name,appo_time) values(@pat_id,@name,@age,@disease,@address,@doc_name,@appo_time)";
                dt.conn.Open();
                dt.comm.Parameters.AddWithValue("@pat_id", TextBox1.Text);
                dt.comm.Parameters.AddWithValue("@name", TextBox2.Text);
                dt.comm.Parameters.AddWithValue("@age", TextBox3.Text);
                dt.comm.Parameters.AddWithValue("@disease", textBox4.Text);
                dt.comm.Parameters.AddWithValue("@address", textBox5.Text);
                dt.comm.Parameters.AddWithValue("@doc_name", textBox6.Text);
                dt.comm.Parameters.AddWithValue("@appo_time", textBox7.Text);
                dt.comm.ExecuteNonQuery();
                dt.conn.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void DisplayData()
        {
            dt.conn.Open();
            dt.comm.CommandText = " select * from patient";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(dt.comm);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            dt.conn.Close();
        }


        private void ClearData()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

        }


          private void Button2_Click_1(object sender, EventArgs e)
        {
            //Update Record  


            if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {

                dt.conn.Open();
                dt.comm.CommandType = CommandType.Text;
                dt.comm.CommandText = "update patient set name= '" + TextBox2.Text + "', age='" + TextBox3.Text + "', disease='" + textBox4.Text + "',address='" + textBox5.Text + "', doc_name='" + textBox6.Text + "', appo_time ='" + textBox7.Text + "'   where pat_id='" + TextBox1.Text + "'";
                dt.comm.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");

                dt.conn.Close();
                DisplayData();
                ClearData();

            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            { 
                dt.conn.Open();
                dt.comm.CommandType = CommandType.Text;
               
                dt.comm.CommandText = "delete from patient where pat_id='" + TextBox1 + "'";
                dt.comm.ExecuteNonQuery();
                dt.conn.Close();

                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide patient id to delete record!");
            }
        
        }


        public class DataAccess
        {
            public SqlConnection conn;
            public SqlCommand comm;

            public DataAccess()
            {
                conn = new SqlConnection();
                comm = new SqlCommand();

                conn.ConnectionString = ConfigurationManager.ConnectionStrings["StudentString"].ConnectionString;
                comm.Connection = conn;
            }
        }

       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Admin_Page Ad = new Admin_Page();
            Ad.Show();
        }

        private void plogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page login = new Login_Page();
            login.Show();
        }

      

       
      

       
    }
}

