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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjeEtkinlik
{

    public partial class ÜyeGirişi : Form
    {
        public ÜyeGirişi()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=UNAL;Initial Catalog=EtkinlikProjesi;Integrated Security=True";
        public static string alinanBilgi;


        private void button2_Click(object sender, EventArgs e)
        {
            // Mevcut formu gizleyin
            this.Hide();

            // ÜyeKayıtOl formunu oluşturun ve gösterin
            AçılışEkranı üyeKayıtOlForm = new AçılışEkranı();
            üyeKayıtOlForm.FormClosed += (s, args) => this.Close(); // ÜyeKayıtOl formu kapatıldığında ana formu kapatın
            üyeKayıtOlForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(conString);
            baglanti.Open();

            if (baglanti.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT * FROM Ogrenciler WHERE OgrenciOkulNo = @OkulNo AND OgrenciSifre = @Sifre";

                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.Parameters.AddWithValue("@OkulNo", txtokulno.Text);
                komut.Parameters.AddWithValue("@Sifre", txtsifre.Text);
                SqlDataReader reader = komut.ExecuteReader();

                alinanBilgi = txtokulno.Text;

                if (reader.HasRows)
                {
                    // Mevcut formu gizleyin
                    this.Hide();

                    // ÜyeKayıtOl formunu oluşturun ve gösterin
                    ÜyeAnaSayfa üyeKayıtOlForm = new ÜyeAnaSayfa();
                    üyeKayıtOlForm.FormClosed += (s, args) => this.Close(); // ÜyeKayıtOl formu kapatıldığında ana formu kapatın
                    üyeKayıtOlForm.Show();
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

    }
}
