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

namespace HastaneSistemi
{
    public partial class hastaKayit : Form
    {

        SqlConnection baglanti;

        public hastaKayit()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            char secilenCinsiyet = ' ';
            if (radio_Erkek.Checked)
            {
                secilenCinsiyet = 'E';
            }
            else if (radio_Kadin.Checked)
            {
                secilenCinsiyet = 'K';
            }
            try
            {
                using (SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-A81BQ9R;Initial Catalog=HastaneDataBase;Integrated Security=True"))
                {
                    baglanti.Open();

                    SqlCommand sqlKomut = new SqlCommand("INSERT INTO Hasta VALUES (@Ad, @Soyad,  @Adres, @Telefon, @Cinsiyet, @DogumTarihi)", baglanti);

                    // Parametreleri ekle
                    sqlKomut.Parameters.AddWithValue("@Ad", txtAd.Text);
                    sqlKomut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                    sqlKomut.Parameters.AddWithValue("@Adres", rTxtAdres.Text);
                    sqlKomut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                    sqlKomut.Parameters.AddWithValue("@Cinsiyet", secilenCinsiyet);
                    sqlKomut.Parameters.AddWithValue("@DogumTarihi", dateTimePicker1.Value);

                    int etkilenenSatirSayisi = sqlKomut.ExecuteNonQuery();

                    if (etkilenenSatirSayisi > 0)
                    {
                        MessageBox.Show("Hasta Kayıt Edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Hasta Kayıt Edilemedi!");
                    }

                    // Text boxları boşalt
                    txtAd.Clear();
                    txtSoyad.Clear();
                    rTxtAdres.Clear();
                    txtTelefon.Clear();
                    radio_Erkek.Checked = false;
                    radio_Kadin.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
            HastaSayfa formAna = new HastaSayfa();
            formAna.Show();
        }
    }
}
