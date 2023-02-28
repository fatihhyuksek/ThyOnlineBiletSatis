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

namespace ThyOnlineBiletSatis
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {   // kayıt formuna yolladık
            Kayıtol kayıt = new Kayıtol();
            kayıt.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Giriş formuna yolladık
            GirisPaneli giris = new GirisPaneli();
            giris.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Giris_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tekrar Bekleriz.");
            Application.Exit();//Formu kapattıktan sonra program arkada çalışmaya devam ettiği için uygulamayı kapat butonu koydum ve program tamamen sonlandı.
        }
    }
}
