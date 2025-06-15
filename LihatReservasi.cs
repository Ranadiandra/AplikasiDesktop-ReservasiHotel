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
using static System.Net.Mime.MediaTypeNames;

namespace AplikasiHotel_CodeStay
{
    public partial class LihatReservasi : Form
    {
        public LihatReservasi()
        {
            InitializeComponent();
            load_data();
            txt_idreservasi.Enabled = false;
            txt_idcustomer.Enabled = false;
            txt_idkamar.Enabled = false;
            txt_checkin.Enabled = false;
            txt_checkout.Enabled = false;
            txt_hargaperhari.Enabled = false;
            txt_ppn.Enabled = false;
            txt_totalharga.Enabled = false;
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjekAkhir_AplikasiHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        private void KelolaReservasi_Load(object sender, EventArgs e)
        {
            

        }
        private void load_data()
        {
            cmd = new SqlCommand("SELECT * FROM Reservasi order by Id_Reservasi asc", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            DataGridView1.RowTemplate.Height = 75;
            DataGridView1.DataSource = dt;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
                string SearchValue = txt_cari.Text.Trim();

                if (!string.IsNullOrWhiteSpace(SearchValue))
                {
                    try
                    {
                        cmd = new SqlCommand(@"SELECT * FROM Reservasi WHERE
                    Id_Customer LIKE @search
                    OR Id_Kamar LIKE @search
                    OR Tanggal_Checkin LIKE @search
                    OR Tanggal_Checkout LIKE @search
                    OR HargaPerHari LIKE @search 
                    OR PPN LIKE @search 
                    OR Total_Harga LIKE @search ORDER BY Id_Reservasi ASC", conn);

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

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            txt_idreservasi.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_idcustomer.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_idkamar.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();

            DateTime checkin = DateTime.Parse(DataGridView1.CurrentRow.Cells[3].Value.ToString());
            DateTime checkout = DateTime.Parse(DataGridView1.CurrentRow.Cells[4].Value.ToString());
            txt_checkin.Text = checkin.ToString("dd/MM/yyyy");
            txt_checkout.Text = checkout.ToString("dd/MM/yyyy");
            txt_hargaperhari.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_ppn.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_totalharga.Text = DataGridView1.CurrentRow.Cells[7].Value.ToString();

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_idcustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Search()
        {
            string SearchValue = txt_cari.Text.Trim();

            if (!string.IsNullOrWhiteSpace(SearchValue))
            {
                try
                {
                    cmd = new SqlCommand(@"SELECT * FROM Reservasi WHERE
                    Id_Customer LIKE @search
                    OR Id_Kamar LIKE @search
                    OR Tanggal_Checkin LIKE @search
                    OR Tanggal_Checkout LIKE @search
                    OR HargaPerHari LIKE @search 
                    OR PPN LIKE @search 
                    OR Total_Harga LIKE @search ORDER BY Id_Reservasi ASC", conn);

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
