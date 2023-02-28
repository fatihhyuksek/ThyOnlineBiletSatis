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
using System.Data.SqlClient;

namespace ThyOnlineBiletSatis
{
    public partial class Kayıtol : Form
    {
        public Kayıtol()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=ThyOnlineBiletSatis;Integrated Security=True");//Sql baglanti
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //girilen tc nin 11 haneli ve telefon numarasını 10 haneli olup olmadığını kontrol ettik.
            if(txtTC.Text.Length==11 && txtTelefon.Text.Length==10)
            {
                baglanti.Open();
                try
                { 
                    //sp oluşturup kayıt için gerekli olan değişkenleri aldık
                    string prosedür2 = "CREATE PROCEDURE up_KayıtOl @TC nvarchar(11),@İsim varchar(50),@Soyisim varchar(50),@Telefon nvarchar(10),@Mail varchar(50),@Şifre varchar(32) AS BEGIN insert into Tbl_Kullanicilar(TC,İsim,Soyisim,Telefon,Mail,Şifre)values(@TC,@İsim,@Soyisim,@Telefon,@Mail,@Şifre) END ";
                    SqlCommand prosedür = new SqlCommand(prosedür2, baglanti);
                    prosedür.ExecuteNonQuery();
                }
                catch
                {

                }

                baglanti.Close();
                
                    baglanti.Open();
                    //sp yi çağırdık.
                    SqlCommand komut = new SqlCommand(" exec up_KayıtOl @k1,@k2,@k3,@k4,@k5,@k6", baglanti);
                    komut.Parameters.AddWithValue("@k1", txtTC.Text);
                    komut.Parameters.AddWithValue("@k2", txtİsim.Text);
                    komut.Parameters.AddWithValue("@k3", txtSoyisim.Text);
                    komut.Parameters.AddWithValue("@k4", txtTelefon.Text);
                    komut.Parameters.AddWithValue("@k5", txtEposta.Text);
                    komut.Parameters.AddWithValue("@k6", txtŞifre.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Eklendi.");
                
            }
            else
            {
                MessageBox.Show("TC veya Telefon numaranızı eksik tuşladınız lütfen tekrar giriniz");
            }
           
            
            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtŞifre.UseSystemPasswordChar = false;

            }
            else if (checkBox1.Checked == false)
            {
                txtŞifre.UseSystemPasswordChar=true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void Kayıtol_Load(object sender, EventArgs e)
        {
            txtŞifre.UseSystemPasswordChar = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //geri dön butonuyla Giriş kısmına geri dönüs yaptık.
            Close();
            Giris giris = new Giris();
            giris.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tekrar Bekleriz.");
            Application.Exit();//Formu kapattıktan sonra program arkada çalışmaya devam ettiği için uygulamayı kapat butonu koydum ve program tamamen sonlandı.
        }

        private void txtTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
