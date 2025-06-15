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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjekAkhir_AplikasiHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        bool mood = true;
        private void btn_save_Click(object sender, EventArgs e)
        {
            string username = iusername.Text;
            string password = ipw.Text;
            string namalengkap = inamalengkap.Text;
            string role = cmbrole.Text;
           

            if (mood)
            {
                SqlCommand cmd = new SqlCommand($"insert into Pengguna(nama, username, password, role)" +
                    $"values('{namalengkap}', '{username}', '{password}', '{role}')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Terdaftar!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();

            }
            else
            {
                MessageBox.Show("Data Tidak Terdaftar!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            inamalengkap.Clear();
            iusername.Clear();
            ipw.Clear();
            cmbrole.SelectedIndex = -1;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //login Login = new login();
            //Login.Show();
            //this.Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
