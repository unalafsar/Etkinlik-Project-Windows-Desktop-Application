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

namespace ProjeEtkinlik
{
    public partial class AdminGirişi : Form
    {
        public AdminGirişi()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=UNAL;Initial Catalog=EtkinlikProjesi;Integrated Security=True";


        private void button2_Click(object sender, EventArgs e)
        {
            // Mevcut formu gizleyin
            this.Hide();

            // ÜyeKayıtOl formunu oluşturun ve gösterin
            AçılışEkranı üyeKayıtOlForm = new AçılışEkranı();
            üyeKayıtOlForm.FormClosed += (s, args) => this.Close(); // ÜyeKayıtOl formu kapatıldığında ana formu kapatın
            üyeKayıtOlForm.Show();
        }

        private void AdminGirişi_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(conString);
            baglanti.Open();

            if (baglanti.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT * FROM Adminler WHERE AdminKullaniciAdi = @adminkullaniciadi AND AdminSifre = @adminsifre";

                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.Parameters.AddWithValue("@adminkullaniciadi", txtkullaniciadi.Text);
                komut.Parameters.AddWithValue("@adminsifre", txtsifre.Text);

                SqlDataReader reader = komut.ExecuteReader();

                if (reader.HasRows)
                {
                    // Mevcut formu gizleyin
                    this.Hide();

                    // ÜyeKayıtOl formunu oluşturun ve gösterin
                    AdminDashboard üyeKayıtOlForm = new AdminDashboard();
                    üyeKayıtOlForm.FormClosed += (s, args) => this.Close(); // ÜyeKayıtOl formu kapatıldığında ana formu kapatın
                    üyeKayıtOlForm.Show();

                    // Bu aşamada kullanıcı girişi yapmıştır, istediğiniz işlemleri burada yapabilirsiniz.
                }
                else
                {
                    // Kullanıcı adı ve/veya şifre yanlış
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                }

                reader.Close();
            }
            else
            {
                MessageBox.Show("Bağlantı hatası.");
            }

            baglanti.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
