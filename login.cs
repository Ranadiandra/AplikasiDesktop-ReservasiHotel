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

namespace AplikasiHotel_CodeStay
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjekAkhir_AplikasiHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            iusername.Clear();
            ipw.Clear();
            cmbrole.SelectedIndex = -1;
        }

        private void password_CheckedChanged(object sender, EventArgs e)
        {
            if (password.Checked)
            {
                ipw.PasswordChar = '\0';
            }
            else
            {
                ipw.PasswordChar = '*';
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string username, password, role;
            username = iusername.Text;
            password = ipw.Text;
            role = cmbrole.Text;

            cmd = new SqlCommand($"SELECT * FROM Pengguna WHERE username= '{username}' AND password ='{password}' AND role ='{role}'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Berhasil Login", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (role == "ADMIN")
                {
                    admin form = new admin();
                    form.Show();
                    this.Hide();
                }
                else if (role == "RESEPSIONIS")
                {
                    resepsioniss form = new resepsioniss();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Gagal Login!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Username, Password atau Role Salah!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ipw_TextChanged(object sender, EventArgs e)
        {

        }

        private void iusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Register regis = new Register();
            //regis.Show();
            //this.Hide();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void panelregis_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
