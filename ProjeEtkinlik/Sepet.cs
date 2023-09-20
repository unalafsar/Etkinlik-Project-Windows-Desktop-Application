using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeEtkinlik
{
    public partial class Sepet : Form
    {
        public int txtokulno { get; private set; }

        public Sepet()
        {
            InitializeComponent();
            textBox1.Text = ÜyeGirişi.alinanBilgi;

        }

        private void button67_Click(object sender, EventArgs e)
        {
            // Mevcut formu gizleyin
            this.Hide();

            // ÜyeKayıtOl formunu oluşturun ve gösterin
            ÜyeAnaSayfa üyeKayıtOlForm = new ÜyeAnaSayfa();
            üyeKayıtOlForm.FormClosed += (s, args) => this.Close(); // ÜyeKayıtOl formu kapatıldığında ana formu kapatın
            üyeKayıtOlForm.Show();
        }

        private void Sepet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'etkinlikProjesiDataSet14.Ogrenciler' table. You can move, or remove it, as needed.
            this.ogrencilerTableAdapter.Fill(this.etkinlikProjesiDataSet14.Ogrenciler);
            // TODO: This line of code loads data into the 'etkinlikProjesiDataSet13.EtkinlikKayıt' table. You can move, or remove it, as needed.
            this.etkinlikKayıtTableAdapter.Fill(this.etkinlikProjesiDataSet13.EtkinlikKayıt);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
