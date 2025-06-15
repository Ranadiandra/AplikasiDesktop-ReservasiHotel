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
    public partial class gymm : Form
    {
        resepsioniss mainForm;
        private string idCustomer;
        private string idReservasi;
        public gymm(string idCustomer, string idReservasi,resepsioniss mainForm)
        {
            InitializeComponent();
            this.idCustomer = idCustomer;
            this.idReservasi = idReservasi;
            this.mainForm = mainForm;
            txt_idgym.Enabled = false;
            txt_idcustomer.Enabled = false;
            
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjekAkhir_AplikasiHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        bool mood = true;
        private Dictionary<string, string> instruktur = new Dictionary<string, string>()
        {
            { "Angkat Beban", "Budi" },
            { "Cardio", "Santi" },
            { "Yoga", "Rina" },
            { "Pilates", "Agus" },
            { "Pound Fit", "Maya" }
        };

        private Dictionary<string, decimal> hargaJenisKelas = new Dictionary<string, decimal>()
        {
            { "Angkat Beban", 95000 },
            { "Cardio", 125000 },
            { "Yoga", 115000 },
            { "Pilates", 170000 },
            { "Pound Fit", 50000 }
        };
        private void gymm_Load(object sender, EventArgs e)
        {
            txt_idcustomer.Text = idCustomer;
            cmb_jenis.Items.AddRange(instruktur.Keys.ToArray());
            cmb_jenis.SelectedIndexChanged += cmb_jenis_SelectedIndexChanged;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cmb_jenis.SelectedItem == null)
            {
                MessageBox.Show("Pilih jenis kelas terlebih dahulu.");
                return;
            }

            string idCustomer = txt_idcustomer.Text;
            string jenisKelas = cmb_jenis.SelectedItem.ToString();
            string namaInstruktur = text_namainstruktur.Text;
            DateTime tanggal = dt_tanggal.Value;
            bool berlangganan = radio_langganan.Checked;

            decimal hargaAsli = hargaJenisKelas[jenisKelas];
            decimal totalHarga = berlangganan ? hargaAsli * 0.95m : hargaAsli; 

            text_total.Text = totalHarga.ToString();

            if (mood)
            {
                cmd = new SqlCommand($"INSERT INTO Gym (Id_Customer, jenis_kelas, nama_instruktur, tanggal, berlangganan, total_harga) " +
                               "VALUES (@Id_Customer, @jenis_kelas, @nama_instruktur, @tanggal, @berlangganan, @total_harga)", conn);

                cmd.Parameters.AddWithValue("@Id_Customer", idCustomer);
                cmd.Parameters.AddWithValue("@jenis_kelas", jenisKelas);
                cmd.Parameters.AddWithValue("@nama_instruktur", namaInstruktur);
                cmd.Parameters.AddWithValue("@tanggal", tanggal);
                cmd.Parameters.AddWithValue("@berlangganan", berlangganan);
                cmd.Parameters.AddWithValue("@total_harga", totalHarga);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Gagal Disimpan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cmb_jenis.SelectedIndex = -1;
            text_namainstruktur.Clear();
            dt_tanggal.Value = DateTime.Now;
            radio_langganan.Checked = false;
            text_total.Clear();
        }

        private void cmb_jenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            string jenis = cmb_jenis.SelectedItem.ToString();
            if (instruktur.ContainsKey(jenis))
            {
                text_namainstruktur.Text = instruktur[jenis];
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            mainForm.loadform(new pembayaran(idCustomer, idReservasi,mainForm));
        }
    }
}
