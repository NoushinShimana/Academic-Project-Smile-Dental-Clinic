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
    public partial class Admin_Page : Form
    {
        DataAccess dt;

        public Admin_Page()
        {
            InitializeComponent();
            LoadComboBox();

        }

        void LoadComboBox()
        {
            dt = new DataAccess();
            dt.comm.CommandText = " select distinct doc_name from patient";
            dt.conn.Open();
            SqlDataReader r = dt.comm.ExecuteReader();
            while (r.Read())
            {

                comboBox1.Items.Add(r[0]);
            }
            dt.conn.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string t = comboBox1.SelectedItem.ToString();
            dt.comm.CommandText = " select * from patient where doc_name='" + t + "'";

            dt.conn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(dt.comm);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dt.conn.Close();
        }


      private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doc_info doc = new Doc_info();
            doc.Show();
        }

       
        private void alogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page login = new Login_Page();
            login.Show();
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

       

       

    }
}
