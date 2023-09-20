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
    public partial class ÜyeAnaSayfa : Form
    {
        public ÜyeAnaSayfa()
        {
            InitializeComponent();
            AssignButtonClickHandlers();
        }

        private void ÜyeAnaSayfa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'etkinlikProjesiDataSet12.Etkinlikler' table. You can move, or remove it, as needed.
            this.etkinliklerTableAdapter1.Fill(this.etkinlikProjesiDataSet12.Etkinlikler);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string conString = "Data Source=UNAL;Initial Catalog=EtkinlikProjesi;Integrated Security=True";


        private void SeatButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            txtkoltukno.Text = clickedButton.Text;
        }

        // panel1salon içindeki tüm butonlara tıklama işlevini atayın
        private void AssignButtonClickHandlers()
        {
            foreach (Control control in salon1panel.Controls)
            {
                if (control is Button)
                {
                    ((Button)control).Click += new EventHandler(SeatButtonClick);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(conString);
            baglanti.Open();
            if (baglanti.State == System.Data.ConnectionState.Open)
            {

                if (!TumBilgilerGecerliMi())
                {
                    return;
                }

                // Parametre kullanarak güvenli bir SQL sorgusu oluşturun
                string query = "INSERT INTO EtkinlikKayıt (Ad, Soyad, TelefonNo, Mail, EtkinlikAdi, KoltukNo, Cinsiyet) VALUES (@Ad, @Soyad, @TelefonNo, @Mail, @EtkinlikAdi, @KoltukNo, @Cinsiyet)";

                SqlCommand komut = new SqlCommand(query, baglanti);

                // Parametre değerlerini atanması
                komut.Parameters.AddWithValue("@Ad", txtad.Text);
                komut.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
                komut.Parameters.AddWithValue("@TelefonNo", txttelno.Text);
                komut.Parameters.AddWithValue("@Mail", txtmail.Text);
                komut.Parameters.AddWithValue("@EtkinlikAdi", comboetkinlikadi.Text);
                komut.Parameters.AddWithValue("@KoltukNo", txtkoltukno.Text);
                komut.Parameters.AddWithValue("@Cinsiyet", checkedListcinsiyet.Text);           

                komut.ExecuteNonQuery();

                if (string.IsNullOrEmpty(txtad.Text ))
                {
                    MessageBox.Show("Lütfen gerekli bilgileri doldurun.");
                    return;
                }

                // ÜyeKayıtOl formunu oluşturun ve gösterin
                SepeteEklendiMessageBox üyeKayıtOlForm = new SepeteEklendiMessageBox();
                üyeKayıtOlForm.FormClosed += (s, args) => this.Close(); // ÜyeKayıtOl formu kapatıldığında ana formu kapatın
                üyeKayıtOlForm.Show();


                // Butonun arka plan rengini değiştirme
                Button foundButton = salon1panel.Controls
                    .OfType<Button>()
                    .FirstOrDefault(btn => btn.Text == txtkoltukno.Text);

                if (foundButton != null && checkedListcinsiyet.Text == "Erkek")
                {
                    foundButton.BackColor = Color.Blue;
                }
                else
                    foundButton.BackColor = Color.Pink;


            }

        }


        private bool TumBilgilerGecerliMi()
        {
            if (string.IsNullOrEmpty(txtad.Text))
            {
                MessageBox.Show("Ad boş bırakılamaz.");
                return false;
            }

            if (string.IsNullOrEmpty(txtsoyad.Text))
            {
                MessageBox.Show("Soyad boş bırakılamaz.");
                return false;
            }

            if (string.IsNullOrEmpty(txttelno.Text))
            {
                MessageBox.Show("Telefon numarası boş bırakılamaz.");
                return false;
            }

            if (string.IsNullOrEmpty(txtmail.Text))
            {
                MessageBox.Show("E-mail boş bırakılamaz.");
                return false;
            }

            if (string.IsNullOrEmpty(comboetkinlikadi.Text))
            {
                MessageBox.Show("Etkinlik adı boş bırakılamaz.");
                return false;
            }

            if (string.IsNullOrEmpty(txtkoltukno.Text))
            {
                MessageBox.Show("Koltuk numarası boş bırakılamaz.");
                return false;
            }

            if (string.IsNullOrEmpty(checkedListcinsiyet.Text))
            {
                MessageBox.Show("Cinsiyet boş bırakılamaz.");
                return false;
            }

            return true;
        }

        private void button67_Click(object sender, EventArgs e)
        {
            // Mevcut formu gizleyin
            this.Hide();

            // ÜyeKayıtOl formunu oluşturun ve gösterin
            ÜyeGirişi üyeKayıtOlForm = new ÜyeGirişi();
            üyeKayıtOlForm.FormClosed += (s, args) => this.Close(); // ÜyeKayıtOl formu kapatıldığında ana formu kapatın
            üyeKayıtOlForm.Show();
        }
    }
}
