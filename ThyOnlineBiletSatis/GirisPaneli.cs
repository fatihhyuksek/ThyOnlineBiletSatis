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

namespace ThyOnlineBiletSatis
{
    public partial class GirisPaneli : Form
    {
        SqlConnection baglanti;// sql baglanti değişkeni
        SqlDataReader dr;// datareader değişkeni
        SqlCommand komut2;
        public string Tc; public string isim; public string soyisim;//Burda tc isim soyisim degiskenlerini tanımladık çünkü bu sayede formlar arası geçişte bilgileri diğer forma aktardık.
        public GirisPaneli()
        {
            InitializeComponent();
        }

        void BilgiAktar()
        {
            baglanti = new SqlConnection("Data Source=.;Initial Catalog=ThyOnlineBiletSatis;Integrated Security=True");//Sql baglanti
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select TC,İsim,Soyisim from tbl_Kullanicilar where TC='" + txtTc.Text + "'", baglanti);//Sql sorgusu
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                //veritabanından verileri okuduk.
                Tc = reader["TC"].ToString();
                isim = reader["İsim"].ToString();
                soyisim = reader["Soyisim"].ToString();
            }
            baglanti.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string user = txtTc.Text;
            string password = txtŞifre.Text;
            BilgiAktar();

            baglanti = new SqlConnection("Data Source=.;Initial Catalog=ThyOnlineBiletSatis;Integrated Security=True");//Sql baglanti
            komut2 = new SqlCommand();
            baglanti.Open();
            komut2.Connection = baglanti;
            komut2.CommandText = "Select * from Tbl_Kullanicilar where TC='" + txtTc.Text +
                "' And Şifre= '" + txtŞifre.Text + "'";//Sorguyla girilen tc ve şifre veritabanındakiyle eşleşyiro mu kontorl ettik.
            dr = komut2.ExecuteReader();

            if (dr.Read())
            {
                //Giriş yapan kişi kullanici ise kullanıcıpaneline yolladık.
                MessageBox.Show("giriş başarılı");
                KullaniciPaneli kullanici = new KullaniciPaneli();
                kullanici.labelTC.Text = Tc;
                kullanici.labelİsim.Text = isim;
                kullanici.labelSoyisim.Text = soyisim;
                kullanici.Show();
                Close();
                
            }
            else
            {
                MessageBox.Show("TC veya şifre hatalı");
            }
           baglanti.Close();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            baglanti = new SqlConnection("Data Source=.;Initial Catalog=ThyOnlineBiletSatis;Integrated Security=True");//Sql bağlantısını kurduk
            komut2 = new SqlCommand();
            baglanti.Open();
            komut2.Connection = baglanti;
            komut2.CommandText = "Select * from Tbl_Calisanlar where Calisan_TC='" + txtTc.Text +
                "' And Şifre= '" + txtŞifre.Text + "'";//Sorguyla girilen tc ve şifre veritabanındakiyle eşleşyiro mu kontorl ettik.
            dr = komut2.ExecuteReader();

            if (dr.Read())
            {
                //Giriş yapan kişi calisan ise calisan paneline yolladık.
                MessageBox.Show("giriş başarılı");
                CalisanPaneli calisan = new CalisanPaneli();
                calisan.Show();
                Close();
            }
            else
            {
                MessageBox.Show("TC veya şifre hatalı");
            }
            baglanti.Close();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user = txtTc.Text;
            string password = txtŞifre.Text;
            
            //Burda adminin otamatik tc ve giriş şifresi verdim.
            if (txtTc.Text == "99999999999" && txtŞifre.Text == "123")
            {
                //Giriş yapan kişi calisan ise calisan paneline yolladık.
                MessageBox.Show("giriş başarılı");
                AdminPaneli admin = new AdminPaneli();
                admin.Show();
                Close();
            }
            else
            {
                MessageBox.Show("TC veya şifre hatalı");
            }
            
        }

        private void GirisPaneli_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtŞifre.UseSystemPasswordChar = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //geri dön butonuyla çıkış yaptık.
            MessageBox.Show("Çıkış yapıyorsunuz...");
            this.Hide();
            Giris giris = new Giris();
            giris.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
          
           
            

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
            MessageBox.Show("Tekrar Bekleriz.");
            Application.Exit();//Formu kapattıktan sonra program arkada çalışmaya devam ettiği için uygulamayı kapat butonu koydum ve program tamamen sonlandı.
        }
    }
}
