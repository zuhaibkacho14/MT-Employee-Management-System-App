using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MT_MS
{
    public partial class EmpAttendance : Form
    {
        public EmpAttendance()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3OM59N;Initial Catalog=MTdb;Integrated Security=True");

        private void load()
        {
            SqlCommand cmd = new SqlCommand("Select * from EmployeeAttendance", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            datagridAttendance.DataSource = dt;

        }
        private void search()
        {
            SqlCommand cmd = new SqlCommand("Select * from Emplytable where name = '" + cboAttendName.SelectedItem+"'", conn);
            try
            {
                
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach(DataRow dr in dt.Rows)
                {
                    txtid.Text = dr["Empid"].ToString();
                    txtname.Text = dr["name"].ToString();
                    cbopositon.Text = dr["position"].ToString();
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

        private void btnBack_Click(object sender, EventArgs e)
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
            SqlCommand cmd = new SqlCommand("Insert into EmployeeAttendance values('" + txtid.Text+"','"+txtname.Text+"','"+cbopositon.SelectedItem+"','"+cbostatus.SelectedItem+"','"+dtpattendance.Value+"')", conn);
            try
            {
                if(txtid.Text=="" || cbostatus.Text == "")
                {
                    MessageBox.Show("Provide Employee Attendance Details", "Info Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    load();
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

        private void cboAttendName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cboBox();
        }

        private void cboBox()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3OM59N;Initial Catalog=MTdb;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select name from Emplytable", conn);
            try
            {
                conn.Open();
                SqlDataReader DR = cmd.ExecuteReader();

                while (DR.Read())
                {
                    cboAttendName.Items.Add(DR[0]);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void EmpAttendance_Load(object sender, EventArgs e)
        {
            load();
            cboBox();
            search();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          var cmd = new SqlCommand("Update EmployeeAttendance set status='"+cbostatus.SelectedItem+"',date= '"+dtpattendance.Value+"' where Empid='"+txtid.Text+"' and date='"+dtpattendance.Value+"'", conn);
            try
            {
                if(txtid.Text=="" || cbostatus.Text == "")
                {
                    MessageBox.Show("Provide Employee Attendance Details", "Info Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    load();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var cmd = new SqlCommand("Delete from EmployeeAttendance where Empid='" + txtid.Text + "' and date='"+dtpattendance.Value+"'", conn);
            try
            {
                if (txtid.Text == "")
                {
                    MessageBox.Show("Provide Employee Attendance Details", "Info Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    load();
                    txtid.Text = "";
                    txtname.Text = "";
                    cbopositon.Text = "";
                    cbostatus.Text = "";
                    cboAttendName.Text = "";
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

        private void btnprint_Click(object sender, EventArgs e)
        {
           /* PrintDialog print = new PrintDialog();
            print.Document = datagridAttendance.*/
        }
    }
}
