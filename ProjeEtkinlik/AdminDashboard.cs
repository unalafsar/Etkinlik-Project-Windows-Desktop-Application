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


namespace ProjeEtkinlik
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            

        }

        public string conString = "Data Source=UNAL;Initial Catalog=EtkinlikProjesi;Integrated Security=True";


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(conString);
            baglanti.Open();
            if (baglanti.State == System.Data.ConnectionState.Open)
            {
                string query = "INSERT INTO Ogrenciler (OgrenciAdi, OgrenciSoyad, OgrenciOkulNo, OgrenciSifre) VALUES (@OgrenciAdi, @OgrenciSoyad, @OgrenciOkulNo, @OgrenciSifre)";

                SqlCommand komut = new SqlCommand(query, baglanti);

                // Parametre değerlerini atanması
                komut.Parameters.AddWithValue("@OgrenciAdi", txtad.Text);
                komut.Parameters.AddWithValue("@OgrenciSoyad", txtsoyad.Text);
                komut.Parameters.AddWithValue("@OgrenciOkulNo", txtokulno.Text);
                komut.Parameters.AddWithValue("@OgrenciSifre", txtsifre.Text);
                

                komut.ExecuteNonQuery();
                MessageBox.Show("Ekleme Başarılı");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(conString);
            baglanti.Open();
            if (baglanti.State == System.Data.ConnectionState.Open)
            {
                string query = "INSERT INTO Salonlar (SalonAdi, KoltukSayisi) VALUES (@SalonAdi, @KoltukSayisi)";

                SqlCommand komut = new SqlCommand(query, baglanti);

                // Parametre değerlerini atanması
                komut.Parameters.AddWithValue("@SalonAdi", txtsalonadı.Text);
                komut.Parameters.AddWithValue("@KoltukSayisi", txtkoltuksayısı.Text);
                

                komut.ExecuteNonQuery();
                MessageBox.Show("Ekleme Başarılı");

                GuncelleComboBoxIcerikSalon();

                txtsalonadı.Clear();
                txtkoltuksayısı.Clear();
            }
        }


        private void GuncelleComboBoxIcerikSalon()
        {
            // ComboBox'ın içeriğini yeniden doldurmak için veritabanından verileri çekin
            SqlConnection baglanti = new SqlConnection(conString);
            string query = "SELECT SalonAdi FROM Salonlar";

            SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // ComboBox'ı yeniden doldurun
            combosalon.DataSource = dataTable;
            combosalon.DisplayMember = "SalonAdi";
            combosalon.ValueMember = "SalonAdi";
        }

        private void GuncelleComboBoxIcerikKategori()
        {
            // ComboBox'ın içeriğini yeniden doldurmak için veritabanından verileri çekin
            SqlConnection baglanti = new SqlConnection(conString);
            string query = "SELECT KategoriAdi FROM Kategoriler";

            SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // ComboBox'ı yeniden doldurun
            combokategori.DataSource = dataTable;
            combokategori.DisplayMember = "KategoriAdi";
            combokategori.ValueMember = "KategoriAdi";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(conString);
            baglanti.Open();
            if (baglanti.State == System.Data.ConnectionState.Open)
            {

                string query = "INSERT INTO Kategoriler (KategoriAdi) VALUES (@KategoriAdi)";

                SqlCommand komut = new SqlCommand(query, baglanti);

                // Parametre değerlerini atanması
                komut.Parameters.AddWithValue("@KategoriAdi", txtkategoriadı.Text);
                
                komut.ExecuteNonQuery();
                MessageBox.Show("Ekleme Başarılı");

                GuncelleComboBoxIcerikKategori();
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'etkinlikProjesiDataSet11.Kategoriler' table. You can move, or remove it, as needed.
            this.kategorilerTableAdapter2.Fill(this.etkinlikProjesiDataSet11.Kategoriler);
            // TODO: This line of code loads data into the 'etkinlikProjesiDataSet10.Salonlar' table. You can move, or remove it, as needed.
            this.salonlarTableAdapter1.Fill(this.etkinlikProjesiDataSet10.Salonlar);
            // TODO: This line of code loads data into the 'etkinlikProjesiDataSet9.Etkinlikler' table. You can move, or remove it, as needed.
            this.etkinliklerTableAdapter5.Fill(this.etkinlikProjesiDataSet9.Etkinlikler);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.salonlarTableAdapter.FillBy(this.etkinlikProjesiDataSet1.Salonlar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            //int salonID = GetSalonIDFromComboBox(combosalon.Text);
            //int kategoriID = GetKategoriIDFromComboBox(combokategori.Text);
            int koltukSayisi = GetKoltukSayisiFromSalon(combosalon.Text);



            SqlConnection baglanti = new SqlConnection(conString);
            baglanti.Open();
            if (baglanti.State == System.Data.ConnectionState.Open)
            {
                // Parametre kullanarak güvenli bir SQL sorgusu oluşturun
                string query = "INSERT INTO Etkinlikler (EtkinlikAdi, KategoriAdi, SalonAdi, EtkinlikTarih, EtkinlikSaat, Kontenjan, EtkinlikFiyat) VALUES (@EtkinlikAdi, @KategoriAdi, @SalonAdi, @EtkinlikTarih, @EtkinlikSaat, @Kontenjan, @EtkinlikFiyat)";

                SqlCommand komut = new SqlCommand(query, baglanti);

                // Parametre değerlerini atanması
                komut.Parameters.AddWithValue("@EtkinlikAdi", txtetkinlikadı.Text);
                komut.Parameters.AddWithValue("@KategoriAdi", combokategori.Text);
                komut.Parameters.AddWithValue("@SalonAdi", combosalon.Text);
                komut.Parameters.AddWithValue("@EtkinlikTarih", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@EtkinlikSaat", dateTimePicker2.Value);
                komut.Parameters.AddWithValue("@Kontenjan", koltukSayisi);
                komut.Parameters.AddWithValue("@EtkinlikFiyat", txtfiyat.Text);


                komut.ExecuteNonQuery();
                MessageBox.Show("Etkinlik Oluşturuldu");


                // Yeni veri ekledikten sonra DataGridView'i yeniden doldurun
                string selectQuery = "SELECT * FROM Etkinlikler";
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, baglanti);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                txtad.Clear();
            }
        }

        private int GetKoltukSayisiFromSalon(string SalonAdi)
        {
            int koltukSayisi = 0;

            SqlConnection baglanti = new SqlConnection(conString);
            baglanti.Open();
            if (baglanti.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT KoltukSayisi FROM Salonlar WHERE SalonAdi = @SalonAdi";
                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.Parameters.AddWithValue("@SalonAdi", SalonAdi);

                // Veriyi oku
                SqlDataReader reader = komut.ExecuteReader();
                if (reader.Read())
                {
                    // Veritabanından koltuk sayısını al
                    koltukSayisi = Convert.ToInt32(reader["KoltukSayisi"]);
                }

                reader.Close();
            }

            baglanti.Close();

            return koltukSayisi;
        }


        // Combobox'tan salon adına göre salonID'yi alacak bir fonksiyon
        /*private int GetSalonIDFromComboBox(string SalonAdi)
        {
            SqlConnection baglanti = new SqlConnection(conString);
            baglanti.Open();
            string query = "SELECT SalonID FROM Salonlar WHERE SalonAdi = @combosalon";
            SqlCommand komut = new SqlCommand(query, baglanti);
            komut.Parameters.AddWithValue("@combosalon", SalonAdi);
            string salonAdi = (int)komut.ExecuteScalar();
            baglanti.Close();
            return salonID;
        }

        // Combobox'tan kategori adına göre kategoriID'yi alacak bir fonksiyon
        private int GetKategoriIDFromComboBox(string kategoriAdi)
        {
            SqlConnection baglanti = new SqlConnection(conString);
            baglanti.Open();
            string query = "SELECT KategoriID FROM Kategoriler WHERE KategoriAdi = @combokategori";
            SqlCommand komut = new SqlCommand(query, baglanti);
            komut.Parameters.AddWithValue("@combokategori", kategoriAdi);
            int kategoriID = (int)komut.ExecuteScalar();
            baglanti.Close();
            return kategoriID;
        }*/

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.kategorilerTableAdapter1.FillBy(this.etkinlikProjesiDataSet2.Kategoriler);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.etkinliklerTableAdapter.FillBy(this.etkinlikProjesiDataSet3.Etkinlikler);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtkategoriadı_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            this.Hide();

            // ÜyeKayıtOl formunu oluşturun ve gösterin
            AdminGirişi üyeKayıtOlForm = new AdminGirişi();
            üyeKayıtOlForm.FormClosed += (s, args) => this.Close(); // ÜyeKayıtOl formu kapatıldığında ana formu kapatın
            üyeKayıtOlForm.Show();
        }
    }
}
