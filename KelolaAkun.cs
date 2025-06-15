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

namespace AplikasiHotel_CodeStay
{
    public partial class KelolaAkun : Form
    {
        public KelolaAkun()
        {
            InitializeComponent();
            load_data();
        }

        string selectedId = "";

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjekAkhir_AplikasiHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        bool mood = true;

        private void load_data()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Pengguna order by id asc", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            guna2DataGridView1.RowTemplate.Height = 75;
            guna2DataGridView1.DataSource = dt;
        }

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
                load_data();
            }
            else
            {
                MessageBox.Show("Data Tidak Terdaftar!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pasword_CheckedChanged(object sender, EventArgs e)
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Pengguna SET nama=@nama, username=@username, password=@password, role=@role WHERE id=@id", conn);
            cmd.Parameters.AddWithValue("@id", selectedId);
            cmd.Parameters.AddWithValue("nama", inamalengkap.Text);
            cmd.Parameters.AddWithValue("username", iusername.Text);
            cmd.Parameters.AddWithValue("password", ipw.Text);
            cmd.Parameters.AddWithValue("role", cmbrole.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Update Data Sukses!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_data();
        }

        private void KelolaAkun_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {
            selectedId = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            inamalengkap.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            iusername.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            ipw.Text = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmbrole.Text = guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Pengguna WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", selectedId);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Berhasil Delete Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                inamalengkap.Text = string.Empty;
                iusername.Text = string.Empty;
                ipw.Text = string.Empty;
                cmbrole.SelectedIndex = -1;
                selectedId = "";
            }
        }
    }
}
