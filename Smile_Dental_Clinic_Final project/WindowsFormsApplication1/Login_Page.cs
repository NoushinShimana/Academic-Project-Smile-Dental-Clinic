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
    public partial class Login_Page : Form
    {

        DataAccess dt;

        public Login_Page()
        { 
            InitializeComponent();
            dt = new DataAccess();
          

            this.BackgroundImage = Properties.Resources._001;

            Timer tm = new Timer();
            tm.Interval = 1670;
            tm.Tick += new EventHandler(ChangeImage);
            tm.Start();


        }



        private void ChangeImage(object sender, EventArgs e)
        {

            List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Properties.Resources._001);
            b1.Add(Properties.Resources._002);
            b1.Add(Properties.Resources._003);
            b1.Add(Properties.Resources._004);
            b1.Add(Properties.Resources._005);
            b1.Add(Properties.Resources._006);
            b1.Add(Properties.Resources._007);
            b1.Add(Properties.Resources._008);
            b1.Add(Properties.Resources._009);
            int index = DateTime.Now.Second % b1.Count;
            this.BackgroundImage = b1[index];

        }


        private void Sbutton_Click_2(object sender, EventArgs e)
        {

        


            if (Spanel.Height == 35)
            {

                Srec1.Visible = true;
                Spanel.Height = 304;
            }

            else
            {
                Srec1.Visible = false;
                Spanel.Height = 35;





            }
        }



         private void Cbutton_Click(object sender, EventArgs e)
        {

            if (Cpanel.Height == 35)
            {
                Crec1.Visible = true;
                Cpanel.Height = 136;
            }

            else
            {
                Crec1.Visible = false;
                Cpanel.Height = 35;

            }
        }


        private void Lbutton_Click_1(object sender, EventArgs e)
        {

            if (Lpanel.Height == 35)
            {
                Lrec1.Visible = true;
                Lpanel.Height = 310;
            }

            else
            {
                Lrec1.Visible = false;
                Lpanel.Height = 35;

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
                //conn.ConnectionString = @"Server=DESKTOP-5AU88UE\SQLEXPRESS;Database=Smile;Trusted_Connection=True;";
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["StudentString"].ConnectionString;
                comm.Connection = conn;
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
               
                SqlCommand cmd = new SqlCommand("Select status from Login where username='"+textBox1.Text+"' and password='"+textBox2.Text+"' ", dt.conn);
              
                dt.conn.Open();

             SqlDataAdapter adapt = new SqlDataAdapter(cmd);
               

                DataTable dtab = new DataTable();
              adapt.Fill(dtab);
                dt.conn.Close();
           
                if (dtab.Rows.Count == 1)
                {

                    if (dtab.Rows[0][0].ToString() == "admin")
                    {
                        MessageBox.Show("Login Successful!");
                        this.Hide();
                        Admin_Page fm1 = new Admin_Page();
                        fm1.Show();
                    }


                    else if (dtab.Rows[0][0].ToString() == "patient")
                    {

                        MessageBox.Show("Login Successful!");
                        this.Hide();
                        Patient_Page fm2 = new Patient_Page();
                        fm2.Show();
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

        private void SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_Up_Page Sign = new Sign_Up_Page();
            Sign.Show();
        }

        }
    }

