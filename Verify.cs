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
    public partial class Verify : Form
    {
        public Verify()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnverify_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3OM59N;Initial Catalog=MTdb;Integrated Security=True");
            String query = "Select Email,password from Admintable where Email = '" + txtverifyemail.Text+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if(txtverifyemail.Text == "")
                {
                    MessageBox.Show("Enter email address");
                }else if(dt.Rows.Count > 0)
                {
                    // txtforgetpass.Text = "admin12";
                    txtforgetpass.Text = (dt.Rows[0]["password"].ToString());
                    txtpassis.Visible = true;
                    txtforgetpass.Visible = true;
                    txtwrong.Visible = false;
                }
                else
                {
                    txtpassis.Visible = false;
                    txtforgetpass.Visible = false;

                    txtwrong.Text = "Wrong Email Enter";
                    txtwrong.ForeColor = Color.Red;
                    txtwrong.Visible = true;
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
    }
}
