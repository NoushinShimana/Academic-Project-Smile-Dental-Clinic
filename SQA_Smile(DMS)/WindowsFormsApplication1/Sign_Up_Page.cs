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
    public partial class Sign_Up_Page : Form
    {
        DataAccess dt;
        public Sign_Up_Page()
        {
            InitializeComponent();
            dt = new DataAccess();
           
        }
   //Insert Record 

    
        private void Create_Click(object sender, EventArgs e)
        {
         if (textBox1.Text != "" && textBox2.Text != "" )
            {
                
            dt.comm.CommandText = "insert into Log(username,password,status) values(@username,@password,@status)";
            dt.conn.Open();
            dt.comm.Parameters.AddWithValue("@username", textBox1.Text);
            dt.comm.Parameters.AddWithValue("@password", textBox2.Text); 
            dt.comm.Parameters.AddWithValue("@status", textBox3.Text);
               dt.comm.ExecuteNonQuery();
                dt.conn.Close();
                MessageBox.Show("Account Created!! Thank You!!");
              
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }
         private void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
           
         
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

         private void SignUplogout_Click(object sender, EventArgs e)
         {
             this.Hide();
             Login_Page login = new Login_Page();
             login.Show();
         }

    }
    }
    

