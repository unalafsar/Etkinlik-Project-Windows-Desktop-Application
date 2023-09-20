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
    public partial class ÜyeKayıtBaşarılıMessageBox : Form
    {
        public ÜyeKayıtBaşarılıMessageBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mevcut formu gizleyin
            this.Hide();

            // ÜyeKayıtOl formunu oluşturun ve gösterin
            ÜyeGirişi üyeKayıtOlForm = new ÜyeGirişi();
            //üyeKayıtOlForm.FormClosed += (s, args) => this.Close(); // ÜyeKayıtOl formu kapatıldığında ana formu kapatın
            üyeKayıtOlForm.Show();
        }
    }
}
