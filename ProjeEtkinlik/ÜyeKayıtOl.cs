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
    public partial class ÜyeKayıtOl : Form
    {
        public ÜyeKayıtOl()
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

        
        private void button1_Click_1(object sender, EventArgs e)
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
                // Mevcut formu gizleyin
                this.Hide();

                // ÜyeKayıtOl formunu oluşturun ve gösterin
                ÜyeKayıtBaşarılıMessageBox üyeKayıtOlForm = new ÜyeKayıtBaşarılıMessageBox();
                //üyeKayıtOlForm.FormClosed += (s, args) => this.Close(); // ÜyeKayıtOl formu kapatıldığında ana formu kapatın
                üyeKayıtOlForm.Show();
            }
        }
    }
}
