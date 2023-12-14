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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
           

        }

        private void Giris_Load(object sender, EventArgs e)
        {
            this.Text = "";
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSayfa adminSayfa = new AdminSayfa();
            adminSayfa.Show();
        }
    }
}
