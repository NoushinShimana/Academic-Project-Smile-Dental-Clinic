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
    public partial class Patient_Page : Form
    { DataAccess dt;
        public Patient_Page()
    {
      
            InitializeComponent();
              LoadComboBox();

        }

        void LoadComboBox()
        {
            dt = new DataAccess();
            dt.comm.CommandText = " select distinct pat_id from patient";
            dt.conn.Open();
            SqlDataReader r = dt.comm.ExecuteReader();
            while (r.Read())
            {

                comboBox1.Items.Add(r[0]);
            }
            dt.conn.Close();
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


        private void pSearch_Click(object sender, EventArgs e)
        {
            string t = comboBox1.SelectedItem.ToString();
            dt.comm.CommandText = " select * from patient where pat_id='" + t + "'";

            dt.conn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(dt.comm);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dt.conn.Close();
        }

        private void pPagelogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page login = new Login_Page();
            login.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Patient_Page_Load(object sender, EventArgs e)
        {

        }

        

       

    }
}