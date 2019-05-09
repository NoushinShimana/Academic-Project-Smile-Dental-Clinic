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
using NUnit;


namespace WindowsFormsApplication1
{
    public partial class Login_Page : Form
    {
      
        DataAccess dt;

        public Login_Page()
        { 
            InitializeComponent();
            dt = new DataAccess();
          

        }

  public class DataAccess
        {
            public SqlConnection conn;
            public SqlCommand comm;
            public DataAccess()
            {
                conn = new SqlConnection();
                comm = new SqlCommand();
              // conn.ConnectionString = @"Server=DESKTOP-5AU88UE\SQLEXPRESS;Database=Smile;Trusted_Connection=True;";
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["StudentString"].ConnectionString;
                comm.Connection = conn;
            }
        }


  public void login_Click(object sender, EventArgs e)
  {



      if (textBox1.Text == "" || textBox2.Text == "")
      {

        string user = "textBox1.Text";
       string pass = "textBox2.Text";
       
         // int? user = Convert.ToInt32("textBox1.Text");
         // int? pass = Convert.ToInt32("textBox2.Text");
         
          null_check(user,pass);
          return;
      }


      else if (textBox1.Text != "" || textBox2.Text != "")
      {
          
          try
          {
              SqlCommand cmd = new SqlCommand("Select status from Log where username='" + textBox1.Text + "' and password='" + textBox2.Text + "' ", dt.conn);
             //  SqlCommand cmd = new SqlCommand("Select status from Log where username='" + textBox1.Text + "' and password='" + textBox2.Text + "' ", dt.conn);
              dt.conn.Open();

              SqlDataAdapter adapt = new SqlDataAdapter(cmd);

              DataTable dtab = new DataTable();
              adapt.Fill(dtab);
              dt.conn.Close();

              if (dtab.Rows.Count == 1)
              {

                  if (dtab.Rows[0][0].ToString() == "admin")
                  {   MessageBox.Show("Login Successful!");
                      this.Hide();
                      Admin_Page fm1 = new Admin_Page();
                      fm1.Show();
                  }

                 
              }

              else
              {
                  MessageBox.Show("Login Failed!");
              }

          }


          catch (Exception ex)
          {
              MessageBox.Show(ex.Message);
          }

      }

      string u = textBox1.Text;
      string p = textBox2.Text;
      AreEq(u, p);
    AreNotEq(u, p);
    AreGrtr(u, p);
  }

  public bool AreEq(string u, string p)
  {
      if (u.Length == "shimana".Length || p.Length == "282".Length)
          MessageBox.Show("Are equal");
    
          return true;
  }

  public bool AreNotEq(string u, string p)
  {
      if (u.Length != "shimana".Length || p.Length != "282".Length)
          MessageBox.Show("Are Not equal");
      return true;
  }
    //public int? null_check(int? user, int? pass)
        public string null_check(string user, string pass)
        {  // int u = user.Length;
          //  int p = pass.Length;
           if (user== null || pass== null)
            MessageBox.Show("Please provide UserName and Password");
                throw new ArgumentNullException("Please provide UserName and Password");
      //  return true;        
        }

        public bool AreGrtr(string u, string p)
        {
            if (u.Length >= 10 || p.Length >= 8)
                MessageBox.Show("please enter less than 11  alphanumeric letters for username and 8 alphanumeric letters for password");
            return true;
        }
      

        public void SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_Up_Page Sign = new Sign_Up_Page();
            Sign.Show();
        }

}
    

}