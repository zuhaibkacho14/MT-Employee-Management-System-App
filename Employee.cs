using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_MS
{
    public partial class Employee : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3OM59N;Initial Catalog=MTdb;Integrated Security=True;");
        public Employee()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
           // string query = "Insert into Emplytable values('" + txtid.Text+"','"+txtname.Text+"','"+txtphone.Text+"','"+txtaddress.Text+"','"+cbogender.SelectedItem+"','"+cboposition.SelectedItem+"')";
            SqlCommand cmd = new SqlCommand("Insert into Emplytable values('" + txtid.Text + "','" + txtname.Text + "','" + txtphone.Text + "','" + txtaddress.Text + "','" + cbogender.SelectedItem + "','" + cboposition.SelectedItem + "')", conn);

            try
            {
                if (txtid.Text == "" || txtname.Text == "" || txtphone.Text == "" || txtaddress.Text=="" || cbogender.Text == "" || cboposition.Text == "")
                {
                    MessageBox.Show("Enter Required Information !", "Missing Information", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                }
                else
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    refresh();
                } 
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            SqlCommand cmd = new SqlCommand("Select * from Emplytable", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            datagridemployee.DataSource = dt;

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Emplytable set name='" + txtname.Text + "', phone='" + txtphone.Text + "',address='" + txtaddress.Text + "', gender='" + cbogender.SelectedItem + "', position='" + cboposition.SelectedItem + "' where Empid = '" + txtid.Text + "'", conn);

            try
            {
                if (txtid.Text == "" || txtname.Text == "" || txtphone.Text == "" || txtaddress.Text == "" || cbogender.Text == "" || cboposition.Text == "")
                {
                    MessageBox.Show("Enter Required Information !", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    datagridemployee.DataSource = dt;
                    refresh();
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

        private void datagridemployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = datagridemployee.SelectedRows[0].Cells[0].Value.ToString();
            txtname.Text = datagridemployee.SelectedRows[0].Cells[1].Value.ToString();
            txtphone.Text = datagridemployee.SelectedRows[0].Cells[2].Value.ToString();
            txtaddress.Text = datagridemployee.SelectedRows[0].Cells[3].Value.ToString();
            cbogender.Text = datagridemployee.SelectedRows[0].Cells[4].Value.ToString();
            cboposition.Text = datagridemployee.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Emplytable where Empid='" + txtid.Text + "'", conn);
            try
            {
                if(txtid.Text == "")
                {
                    MessageBox.Show("Enter EmpID");
                }
                else
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    refresh();
                    reset();
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            txtid.Text = "";
            txtname.Text = "";
            txtphone.Text = "";
            txtaddress.Text = "";
            cbogender.Text = "";
            cboposition.Text = "";
        }
    }
}
