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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HastaneSistemi
{
    public partial class hastaListele : Form
    {
        SqlConnection baglanti;

        public hastaListele()
        {
            InitializeComponent();
            dGridHasta.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            listele();
        }

        private void listele()
        {
            try
            {
                baglanti = new SqlConnection(@"Data Source=DESKTOP-A81BQ9R;Initial Catalog=HastaneDataBase;Integrated Security=True");
                baglanti.Open();

                SqlCommand sqlKomut1 = new SqlCommand("SELECT * FROM dbo.Hasta", baglanti);
                SqlDataReader sqlDR = sqlKomut1.ExecuteReader(); // Sorguyu yapar

                dGridViewListele(sqlDR);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti != null)
                    baglanti.Close();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
            HastaSayfa formAna = new HastaSayfa();
            formAna.Show();
        }
       
        private void dGridViewListele(SqlDataReader sqlDR)
        {
            dGridHasta.Font = new Font("Arial", 10, FontStyle.Bold);
            dGridHasta.ColumnCount = 7; // Toplam sütun sayısını ayarla
            while (sqlDR.Read())
            {
                int i = dGridHasta.Rows.Add(); // Her döngüde yeni bir satır ekle


                dGridHasta.Columns[0].Name = "Hasta Id";
                dGridHasta.Columns[1].Name = "Hasta Ad";
                dGridHasta.Columns[2].Name = "Hasta Soyad";
                dGridHasta.Columns[3].Name = "Hasta Adres";
                dGridHasta.Columns[4].Name = "Hasta Telefon";
                dGridHasta.Columns[5].Name = "Hasta Cinsiyet";
                dGridHasta.Columns[6].Name = "Hasta Doğum Tarih";

                dGridHasta.Rows[i].Cells[0].Value = sqlDR[0].ToString(); // Hasta Id
                dGridHasta.Rows[i].Cells[1].Value = sqlDR[1].ToString(); // Hasta Ad
                dGridHasta.Rows[i].Cells[2].Value = sqlDR[2].ToString(); // Hasta Soyad
                dGridHasta.Rows[i].Cells[3].Value = sqlDR[3].ToString(); // Hasta Adres
                dGridHasta.Rows[i].Cells[4].Value = sqlDR[4].ToString(); // Hasta Telefon
                dGridHasta.Rows[i].Cells[5].Value = sqlDR[5].ToString(); // Hasta Cinsiyet
                dGridHasta.Rows[i].Cells[6].Value = sqlDR[6].ToString(); // Hasta Doğum Tarih

                dGridHasta.Columns[0].Width = 55; // Tablo genişlikleri
                dGridHasta.Columns[1].Width = 150;
                dGridHasta.Columns[2].Width = 150;
                dGridHasta.Columns[3].Width = 400;
                dGridHasta.Columns[4].Width = 150;
                dGridHasta.Columns[5].Width = 75;

            }
        }
    }
}
