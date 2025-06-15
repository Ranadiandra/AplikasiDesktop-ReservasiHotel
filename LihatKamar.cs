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
    public partial class LihatKamar : Form
    {
        public LihatKamar()
        {
            InitializeComponent();
            txt_idkamar.ReadOnly = true;
            txt_nomerkamar.ReadOnly = true;
            txt_hargakamar.ReadOnly = true;
            txt_status.ReadOnly = true;
            txt_tipekamar.ReadOnly = true;
            txt_fasilitas.ReadOnly = true;
            LoadData();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjekAkhir_AplikasiHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        private void LoadData()
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM KelolaKamar ORDER BY Id_Kamar ASC", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataGridView1.DataSource = dt;
                DataGridView1.ReadOnly = true;
                DataGridView1.RowTemplate.Height = 75;
                DataGridViewImageColumn pic1 = new DataGridViewImageColumn();
                pic1 = (DataGridViewImageColumn)DataGridView1.Columns[6];
                pic1.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_cari_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_idkamar_TextChanged(object sender, EventArgs e)
        {

        }

        private void LihatKamar_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            Search();
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_idkamar_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idkamar.Text = DataGridView1.CurrentRow.Cells["Id_Kamar"].Value.ToString();
            txt_nomerkamar.Text = DataGridView1.CurrentRow.Cells["nokamar"].Value.ToString();
            txt_tipekamar.Text = DataGridView1.CurrentRow.Cells["tipekamar"].Value.ToString();
            txt_fasilitas.Text = DataGridView1.CurrentRow.Cells["fasilitas"].Value.ToString();
            txt_hargakamar.Text = DataGridView1.CurrentRow.Cells["harga"].Value.ToString();
            txt_status.Text = DataGridView1.CurrentRow.Cells["status"].Value.ToString();

            MemoryStream ms = new MemoryStream((byte[])DataGridView1.CurrentRow.Cells[6].Value);
            pictureBox1.Image = Image.FromStream(ms);
        }
        private void Search()
        {
            string SearchValue = txt_cari.Text.Trim();

            if (!string.IsNullOrWhiteSpace(SearchValue))
            {
                try
                {
                    cmd = new SqlCommand(@"SELECT * FROM KelolaKamar WHERE
                    nokamar LIKE @search
                    OR tipekamar LIKE @search
                    OR fasilitas LIKE @search
                    OR harga LIKE @search
                    OR status LIKE @search ORDER BY Id_Kamar ASC", conn);

                    cmd.Parameters.AddWithValue("@search", "%" + SearchValue + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);

                    DataGridView1.RowTemplate.Height = 75;
                    DataGridView1.DataSource = dt;
                    DataGridViewImageColumn pic1 = (DataGridViewImageColumn)DataGridView1.Columns[6];
                    pic1.ImageLayout = DataGridViewImageCellLayout.Stretch;

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

        private void txt_cari_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
