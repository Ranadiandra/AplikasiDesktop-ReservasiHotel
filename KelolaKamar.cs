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
    public partial class KelolaKamar : Form
    {
        public KelolaKamar()
        {
            InitializeComponent();
            load_data();
            txt_idkamar.ReadOnly = true;
            
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjekAkhir_AplikasiHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        private void KelolaKamar_Load(object sender, EventArgs e)
        {

        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select KelolaKamar(*.JpG; *.png; *.Gif)|*.JpG; *.png; *.Gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into KelolaKamar (nokamar, tipekamar, fasilitas, harga, status, gambar) values (@nokamar, @tipekamar, @fasilitas, @harga, @status, @gambar)", conn);
            cmd.Parameters.AddWithValue("nokamar", txt_nomerkamar.Text);
            cmd.Parameters.AddWithValue("tipekamar", cmb_tipekamar.Text);
            cmd.Parameters.AddWithValue("fasilitas", txt_fasilitas.Text);
            cmd.Parameters.AddWithValue("harga", txt_hargakamar.Text);
            cmd.Parameters.AddWithValue("status", cmb_status.Text);

            MemoryStream mor = new MemoryStream();
            pictureBox1.Image.Save(mor, pictureBox1.Image.RawFormat);
            cmd.Parameters.AddWithValue("gambar", mor.ToArray());

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Insert Data Sukses!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_data();

            txt_nomerkamar.Text = string.Empty;
            txt_fasilitas.Text = string.Empty;
            txt_hargakamar.Text = string.Empty;
            cmb_tipekamar.SelectedIndex = -1;
            cmb_status.SelectedIndex = -1;
            txt_idkamar.Text = string.Empty;
            pictureBox1.Image = null;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txt_hargakamar.Text, out decimal harga))
            {
                MessageBox.Show("Masukkan harga dalam angka yang valid (misalnya 100000.00)", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cmd = new SqlCommand("update KelolaKamar set nokamar = @nokamar, tipekamar = @tipekamar, fasilitas = @fasilitas, harga = @harga, status = @status where Id_Kamar = @Id_Kamar", conn);
            cmd.Parameters.AddWithValue("@Id_Kamar", txt_idkamar.Text);
            cmd.Parameters.AddWithValue("@nokamar", txt_nomerkamar.Text);
            cmd.Parameters.AddWithValue("@tipekamar", cmb_tipekamar.Text);
            cmd.Parameters.AddWithValue("@fasilitas", txt_fasilitas.Text);
            cmd.Parameters.AddWithValue("@harga", harga); 
            cmd.Parameters.AddWithValue("@status", cmb_status.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Update Data Sukses!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_data();
            txt_nomerkamar.Text = string.Empty;
            txt_fasilitas.Text = string.Empty;
            txt_hargakamar.Text = string.Empty;
            cmb_tipekamar.SelectedIndex = -1;
            cmb_status.SelectedIndex = -1;
            txt_idkamar.Text = string.Empty;
            pictureBox1.Image = null;
        }
        private void load_data()
        {
            cmd = new SqlCommand("select * from KelolaKamar order by Id_Kamar asc", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            DataGridView1.RowTemplate.Height = 75;
            DataGridView1.DataSource = dt;
            DataGridViewImageColumn pic1 = new DataGridViewImageColumn();
            pic1 = (DataGridViewImageColumn)DataGridView1.Columns[6];
            pic1.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            string idKamar = txt_idkamar.Text;

            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Reservasi WHERE Id_Kamar = @Id_Kamar", conn);
            checkCmd.Parameters.AddWithValue("@Id_Kamar", idKamar);

            conn.Open();
            int count = (int)checkCmd.ExecuteScalar();
            conn.Close();

            if (count > 0)
            {
                MessageBox.Show("Kamar ini sudah digunakan dalam reservasi dan tidak bisa dihapus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd = new SqlCommand("DELETE FROM KelolaKamar WHERE Id_Kamar=@Id_Kamar", conn);
                cmd.Parameters.AddWithValue("Id_Kamar", txt_idkamar.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Berhasil Delete Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                txt_nomerkamar.Text = string.Empty;
                txt_fasilitas.Text = string.Empty;
                txt_hargakamar.Text = string.Empty;
                cmb_tipekamar.SelectedIndex = -1;
                cmb_status.SelectedIndex = -1;
                txt_idkamar.Text = string.Empty;
                pictureBox1.Image = null;
            }
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmb_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmb_tipekamar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tipekamar.Text == "STANDARD ROOM")
            {
                txt_fasilitas.Text = "Tempat Tidur Single/Double, TV Layar Datar, Wifi";
            }
            else if (cmb_tipekamar.Text == "DELUXE ROOM")
            {
                txt_fasilitas.Text = "Perlengkapan Mandi Lengkap, AC, Smart TV, Wifi";
            }
            else if (cmb_tipekamar.Text == "SUITE ROOM")
            {
                txt_fasilitas.Text = "Kolam Renang, Layanan Kamar 24 Jam, Smart TV dan Wifi";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_hargakamar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_nomerkamar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_Click_1(object sender, EventArgs e)
        {
            txt_idkamar.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_nomerkamar.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            cmb_tipekamar.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_fasilitas.Text = DataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_hargakamar.Text = DataGridView1.CurrentRow.Cells[4].Value.ToString();
            cmb_status.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            MemoryStream ms = new MemoryStream((byte[])DataGridView1.CurrentRow.Cells[6].Value);
            pictureBox1.Image = Image.FromStream(ms);
        }

        private void txt_cari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Search();
            }
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
