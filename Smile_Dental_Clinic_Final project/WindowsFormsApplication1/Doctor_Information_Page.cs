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
    public partial class Doctor_Information_Page : Form
    {

        DataAccess dt;

        public Doctor_Information_Page()
        {
            InitializeComponent();
            dt = new DataAccess();
            DisplayData();
        }


        //Insert Record 

        private void Button1_Click_1(object sender, EventArgs e)
        {


            if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && textBox4.Text != "")
            {
                dt.comm.CommandText = "insert into doc(doc_id,name,designation,work_time) values(@doc_id,@name,@designation,@work_time)";
                dt.conn.Open();
                dt.comm.Parameters.AddWithValue("@doc_id", TextBox1.Text);
                dt.comm.Parameters.AddWithValue("@name", TextBox2.Text);
                dt.comm.Parameters.AddWithValue("@designation", TextBox3.Text);
                dt.comm.Parameters.AddWithValue("@work_time", textBox4.Text);
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
            dt.comm.CommandText = " select * from doc";
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
         
        }

      

        //Update Record  


        private void Button2_Click(object sender, EventArgs e)
        {

             if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && textBox4.Text != "")
            {

            dt.conn.Open();
            dt.comm.CommandType = CommandType.Text;
            dt.comm.CommandText = "update doc set name= '" + TextBox2.Text + "',designation='" + TextBox3.Text + "',work_time='" + textBox4.Text + "' where doc_id='" + TextBox1.Text + "'";
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

        //Delete Record  
        private void button3_Click(object sender, EventArgs e)
        {
                if (TextBox1.Text != "" )
            {
                dt.conn.Open();
                dt.comm.CommandType = CommandType.Text;
                dt.comm.CommandText = "delete from doc where doc_id='" + TextBox1.Text + "'";
                dt.comm.ExecuteNonQuery();
                dt.conn.Close();

                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
                  }
             else
             {
                 MessageBox.Show("Please Provide doc_id to delete record!");
             }
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Page ob = new Login_Page();
            ob.Show();
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

        private void dlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page login = new Login_Page();
            login.Show();
        }

        private void dGoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Admin_Page login = new Admin_Page();
            login.Show();
        }

    
       

       

    }
}

       