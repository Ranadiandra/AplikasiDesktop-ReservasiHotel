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

namespace AplikasiHotel_CodeStay
{
    public partial class LihatDataCostumer : Form
    {
        resepsioniss mainForm;
        
        public LihatDataCostumer()
        {
            InitializeComponent();
            load_data();
            txt_idcustomer.Enabled = false;
            txt_nik.Enabled = false;
            txt_nama.Enabled = false;
            txt_alamat.Enabled = false;
            txt_nohp.Enabled = false;
        }

        public LihatDataCostumer(resepsioniss form)
        {
            InitializeComponent();
            mainForm = form;
            load_data();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjekAkhir_AplikasiHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void LihatDataCostumer_Load(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UPDATE DataCustomer SET NIK=@NIK, Nama=@Nama, Alamat=@Alamat, No_HP=@No_HP WHERE Id_Customer=@Id_Customer", conn);
            cmd.Parameters.AddWithValue("@Id_Customer", txt_idcustomer.Text);
            cmd.Parameters.AddWithValue("NIK", txt_nik.Text);
            cmd.Parameters.AddWithValue("Nama", txt_nama.Text);
            cmd.Parameters.AddWithValue("Alamat", txt_alamat.Text);
            cmd.Parameters.AddWithValue("No_HP", txt_nohp.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Update Data Sukses!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_data();
        }
        private void load_data()
        {
            cmd = new SqlCommand("SELECT * FROM DataCustomer order by Id_Customer asc", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            DataGridView1.RowTemplate.Height = 75;
            DataGridView1.DataSource = dt;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data Ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd = new SqlCommand("DELETE FROM DataCustomer WHERE Id_Customer=@Id_Customer", conn);
                cmd.Parameters.AddWithValue("Id_Customer", txt_idcustomer.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                txt_idcustomer.Text = string.Empty;
                txt_nik.Text = string.Empty;
                txt_nama.Text = string.Empty;
                txt_alamat.Text = string.Empty;
                txt_nohp.Text = string.Empty;
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_cari_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_idcostumer_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_Click_1(object sender, EventArgs e)
        {
            txt_idcustomer.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_nik.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_nama.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_alamat.Text = DataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_nohp.Text = DataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void Search()
        {
            string SearchValue = txt_cari.Text.Trim();

            if (!string.IsNullOrWhiteSpace(SearchValue))
            {
                try
                {
                    cmd = new SqlCommand(@"SELECT * FROM DataCustomer WHERE
                    NIK LIKE @search
                    OR Nama LIKE @search
                    OR Alamat LIKE @search
                    OR No_HP LIKE @search ORDER BY Id_Customer ASC", conn);

                    cmd.Parameters.AddWithValue("@search", "%" + SearchValue + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);

                    DataGridView1.RowTemplate.Height = 75;
                    DataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Maaf Data Tidak Ditemukan!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi Kesalahan!!: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silahkan Masukkan Kata Kunci Pencarian!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_cari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Search();
            }
        }
    }
}
