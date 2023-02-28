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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ThyOnlineBiletSatis
{
    public partial class CalisanEkle : Form
    {
        public CalisanEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=ThyOnlineBiletSatis;Integrated Security=True");//Sql baglanti
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            try
            { 
                //Sp oluşturduk admin panelinde çalışan ekleyebileceğimiz sorguyu yazdık.
                string prosedür1 = "CREATE PROCEDURE up_CalisanEkle @Calisan_TC nvarchar(11),@İsim varchar(50),@Soyisim varchar(50),@Telefon nvarchar(10),@Mail varchar(50),@Şifre varchar(32) AS BEGIN insert into Tbl_Calisanlar(Calisan_TC,İsim,Soyisim,Telefon,Mail,Şifre)values(@TC,@İsim,@Soyisim,@Telefon,@Mail,@Şifre) END ";
                SqlCommand prosedür = new SqlCommand(prosedür1, baglanti);
                prosedür.ExecuteNonQuery();
            } 
            catch
            {

            }
            baglanti.Close();
            baglanti.Open();
            //Yazdığımız sp yi çalıştırdık.
            SqlCommand komut = new SqlCommand("exec up_CalisanEkle @k1,@k2,@k3,@k4,@k5,@k6", baglanti);
            komut.Parameters.AddWithValue("@k1", txtTC.Text);
            komut.Parameters.AddWithValue("@k2", txtİsim.Text);
            komut.Parameters.AddWithValue("@k3", txtSoyisim.Text);
            komut.Parameters.AddWithValue("@k4", txtTelefon.Text);
            komut.Parameters.AddWithValue("@k5", txtEposta.Text);
            komut.Parameters.AddWithValue("@k6", txtŞifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Çalışan Eklendi.");
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtŞifre.UseSystemPasswordChar = false;

            }
            else if (checkBox1.Checked == false)
            {
                txtŞifre.UseSystemPasswordChar = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulamayı Kapatıyorsunuz.");
            Application.Exit();//Formu kapattıktan sonra program arkada çalışmaya devam ettiği için uygulamayı kapat butonu koydum ve program tamamen sonlandı.
        }

        private void button4_Click(object sender, EventArgs e)
        {

            AdminPaneli admin = new AdminPaneli();
            admin.Show();
            Close();//Geri dön butonuya formu kapatıp bir önceki forma geri döndük.
        }

        private void CalisanEkle_Load(object sender, EventArgs e)
        {
            txtŞifre.UseSystemPasswordChar = true;
        }
    }
}
