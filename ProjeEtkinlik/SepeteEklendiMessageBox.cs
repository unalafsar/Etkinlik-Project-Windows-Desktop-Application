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
    public partial class SepeteEklendiMessageBox : Form
    {
        public SepeteEklendiMessageBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mevcut formu gizleyin
            this.Hide();

            // ÜyeKayıtOl formunu oluşturun ve gösterin
            Sepet üyeKayıtOlForm = new Sepet();
            //üyeKayıtOlForm.FormClosed += (s, args) => this.Close(); // ÜyeKayıtOl formu kapatıldığında ana formu kapatın
            üyeKayıtOlForm.Show();
        }
    }
}
