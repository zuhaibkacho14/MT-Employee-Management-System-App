using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_MS
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3OM59N;Initial Catalog=MTdb;Integrated Security=True");

        private void comboxSearch()
        {
            var cmd = new SqlCommand("select DISTINCT(name) from EmployeeAttendance", conn);

            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cboView.Items.Add(rd[0]);
            }
            conn.Close();
        }
        private void cbosearch_Click(object sender, EventArgs e)
        {
            var cmd = new SqlCommand("Select * from EmployeeAttendance where name='" + cboView.SelectedItem + "'", conn);
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                datagridViewEmp.DataSource = dt;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void View_Load(object sender, EventArgs e)
        {
            comboxSearch();
        }
    }
}
