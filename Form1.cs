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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3OM59N;Initial Catalog=MTdb;Integrated Security=True");
            String query = "Select * from Admintable where name = '" + txtusername.Text + "' and password='" + txtpassword.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if(txtusername.Text =="" || txtpassword.Text == "")
                {
                    MessageBox.Show("Enter Required Information", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else if(dt.Rows.Count > 0)
                {
                    txterror.Visible = false;
                    Home hm = new Home();
                    hm.Show();
                    this.Hide();
                }
                else
                {
                    txterror.Visible = true;
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnforget_Click(object sender, EventArgs e)
        {
            Verify vf = new Verify();
            vf.ShowDialog();
        }
    }
}
