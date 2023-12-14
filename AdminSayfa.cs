using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneSistemi
{
    public partial class AdminSayfa : Form
    {
        public AdminSayfa()
        {
            InitializeComponent();
            button3.FlatStyle = FlatStyle.Flat; // Butonun düz görünümünü ayarla

        }
        private void btn_hastaListe_Click(object sender, EventArgs e)
        {
            hastaListele hastaList = new hastaListele();
            hastaList.Show(); // Hasta Listeleme Formunu Aç
            this.Hide();       // Bu formu gizle
        }

        private void btn_hastaKayit_Click(object sender, EventArgs e)
        {
            hastaKayit hastaKay = new hastaKayit();
            hastaKay.Show();
            this.Hide();
        }
    }
}
