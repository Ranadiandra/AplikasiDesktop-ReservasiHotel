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
    public partial class Resto : Form
    {
        private string idCustomer;
        private string idReservasi;
        resepsioniss mainForm;
        public Resto(string idCustomer, string idReservasi, resepsioniss mainForm)
        {
            InitializeComponent();
            txt_idcustomer.Enabled = false;
            this.idCustomer = idCustomer;
            this.mainForm = mainForm;
            this.idReservasi = idReservasi;
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjekAkhir_AplikasiHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        private string currentView = "Menu";

        //library
        List<string> pesananList = new List<string>();
        decimal totalHarga = 0;
        decimal selectedHarga = 0;

        private void setup_tabel()
        {
            tabel_menu.ColumnHeadersVisible = true;
            tabel_menu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabel_menu.ScrollBars = ScrollBars.Both;
            tabel_menu.ColumnHeadersHeight = 30;
            tabel_menu.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            tabel_menu.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

        }

        public void search_menu()
        {
            string keyword = text_search.Text.Trim();

            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT Id_menu AS [ID], Nama_Menu AS [Nama Menu], Kategori AS [Kategori], Harga AS [Harga], Stok AS [Stok] " +
                                     "FROM Menu WHERE CONCAT(CAST(Id_Menu AS VARCHAR), Nama_Menu, Kategori, CAST(Harga AS VARCHAR), CAST(Stok AS VARCHAR)) LIKE @keyword", conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                tabel_menu.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mencari menu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void search_order()
        {
            string keyword = text_search.Text.Trim();

            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT Id_Pesanan AS [ID Pesanan], Id_Menu AS [ID Menu], Id_Customer AS [ID Customer], Total_Harga AS [Total Harga], PPN AS [PPN 5%], Total_Bayar AS [Total Bayar]" +
                                     "FROM Pesanan WHERE CAST(Id_Pesanan AS VARCHAR) LIKE @keyword", conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                tabel_menu.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mencari menu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void load_menu()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT Id_menu AS [ID], Nama_Menu AS [Nama Menu], Kategori AS [Kategori], Harga AS [Harga], Stok AS [Stok] FROM Menu", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                tabel_menu.DataSource = dt;
                tabel_menu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                tabel_menu.ColumnHeadersVisible = true;
                //tabel_menu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load menu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void load_order()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT Id_Pesanan AS [ID Pesanan], Id_Menu AS [ID Menu], Id_Customer AS [ID Customer], Total_Harga AS [Total Harga], PPN AS [PPN 5%], Total_Bayar AS [Total Bayar] FROM Pesanan", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                tabel_menu.DataSource = dt;
                tabel_menu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                tabel_menu.ColumnHeadersVisible = true;
                //tabel_menu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load menu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void updateMenu()
        {
            // Ambil ID Menu dari baris yang dipilih
            int id_menu = Convert.ToInt32(tabel_menu.CurrentRow.Cells[0].Value);

            // Ambil jumlah stok produk yang ada di tabel Produk
            cmd = new SqlCommand($"SELECT Stok FROM Menu WHERE Id_Menu = {id_menu};", conn);
            conn.Open();
            int stokMenu = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            int jumlahPesan = Convert.ToInt32(numeric.Text);
            int stokBaru = stokMenu - jumlahPesan;

            // mengupdate stok di tabel menu
            cmd = new SqlCommand($"UPDATE Menu SET Stok = {stokBaru} WHERE Id_Menu = {id_menu};", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            load_menu();
        }
        private void btn_tambah_Click(object sender, EventArgs e)
        {
            int jumlah = (int)numeric.Value;
            string namaMenu = label_menu.Text;
            decimal subtotal = selectedHarga * jumlah;
            totalHarga += subtotal;

            string pesanan = $"{namaMenu} x{jumlah} = Rp{subtotal:N0}";
            pesananList.Add(pesanan);
            listBox1.DataSource = null;
            listBox1.DataSource = pesananList;
        }

        private void Resto_Load(object sender, EventArgs e)
        {
                txt_idcustomer.Text = idCustomer;
            try
            {
                conn.Open();
                // cek apakah data ada di tabel
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Menu", conn);
                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {
                    string query = "INSERT INTO Menu (Nama_Menu, Kategori, Harga, Stok) VALUES " +
                                   "('Nasi Goreng', 'Makanan', 15000, 50), " +
                                   "('Ayam Bakar', 'Makanan', 17000, 50), " +
                                   "('Ikan Bakar', 'Makanan', 20000, 50), " +
                                   "('Rendang', 'Makanan', 10000, 50), " +
                                   "('Soto', 'Makanan', 15000, 50), " +
                                   "('Es Kuwut', 'Minuman', 5000, 50), " +
                                   "('Es Doger', 'Minuman', 8000, 50), " +
                                   "('Es Teler', 'Minuman', 10000, 50);";

                    SqlCommand insertCmd = new SqlCommand(query, conn);
                    insertCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat inisialisasi data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            // Memanggil load menu
            load_menu();
            setup_tabel();
        }

        private void tabel_menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // untuk menampilkan nama menu saat baris di klik
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tabel_menu.Rows[e.RowIndex];
                label_menu.Text = row.Cells[1].Value.ToString();
                selectedHarga = Convert.ToDecimal(row.Cells[3].Value);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string idCustomer = txt_idcustomer.Text;
            decimal ppn = totalHarga * 0.05m;
            decimal totalBayar = totalHarga + ppn;

            text_total.Text = totalHarga.ToString("N2");
            text_ppn.Text = ppn.ToString("N2");
            text_jumlahbayar.Text = totalBayar.ToString("N2");

            try
            {
                conn.Open();
                if (tabel_menu.SelectedRows.Count > 0)
                {
                    int id_menu = Convert.ToInt32(tabel_menu.SelectedRows[0].Cells["ID"].Value);
                    cmd = new SqlCommand($"INSERT INTO Pesanan(Id_Menu, Id_Customer,Total_Harga, PPN, Total_Bayar) " +
                           "VALUES (@Id_Menu, @Id_Customer,@Total_Harga, @PPN, @Total_Bayar)", conn);

                    cmd.Parameters.AddWithValue("@Id_Menu", id_menu);
                    cmd.Parameters.AddWithValue("@Id_Customer", Convert.ToInt32(idCustomer));
                    cmd.Parameters.AddWithValue("@Total_Harga", totalHarga);
                    cmd.Parameters.AddWithValue("@PPN", ppn);
                    cmd.Parameters.AddWithValue("@Total_Bayar", totalBayar);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pesanan berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Silakan pilih menu terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan pesanan: " + ex.Message);
            }
            finally
            {
                conn.Close();
                updateMenu();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            pesananList.Clear();
            listBox1.DataSource = null;
            totalHarga = 0;
            text_total.Text = text_ppn.Text = text_jumlahbayar.Text = "";
        }
        private void btn_datamenu_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_dataorder_Click(object sender, EventArgs e)
        {
            
        }

        private void text_search_TextChanged(object sender, EventArgs e)
        {
            //apabila tabel menampilkan data menu maka akan melakukan pencarian data menu
            if (currentView == "Menu")
            {
                search_menu();
            }//apabila tabel menampilkan data pesanan maka akan melakukan pencarian data pesanan
            else if (currentView == "Order")
            {
                search_order();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            mainForm.loadform(new pembayaran(idReservasi, idCustomer, mainForm));
        }

        private void btn_dataorder_Click_1(object sender, EventArgs e)
        {
            currentView = "Order";
            load_order();
        }

        private void btn_datamenu_Click_1(object sender, EventArgs e)
        {
            currentView = "Menu";
            load_menu();
        }
    }
}
