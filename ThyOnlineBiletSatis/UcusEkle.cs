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
    public partial class UcusEkle : Form
    {
        SqlCommand komut;
        SqlDataReader dr;
        DataSet ds = new DataSet();
        
        public UcusEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=ThyOnlineBiletSatis;Integrated Security=True");//Sqlbaglanti
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            try
            {
                //Ucus eklemek için sp oluşturduk
                string prosedür4 = "CREATE PROCEDURE up_UcusEkle @Nereden varchar(50),@Nereye varchar(50),@Tarih varchar(50),@Saat time(0),@Koltuk_Sayısı int,@Fiyat money AS BEGIN insert into Ucuslar(Nereden,Nereye,Tarih,Saat,Koltuk_Sayısı,Fiyat)values(@Nereden,@Nereye,@Tarih,@Saat,@Koltuk_Sayısı,@Fiyat) END ";
                SqlCommand prosedür = new SqlCommand(prosedür4, baglanti);
                prosedür.ExecuteNonQuery();
            }
            catch
            {

            }
            baglanti.Close();
            baglanti.Open();
            // sp yi çalıştırdık.
            SqlCommand komut = new SqlCommand("exec up_UcusEkle @k1,@k2,@k3,@k4,@k5,@k6", baglanti);
            komut.Parameters.AddWithValue("@k1", txtNereden.Text);
            komut.Parameters.AddWithValue("@k2", txtNereye.Text);
            komut.Parameters.AddWithValue("@k3", txtTarih.Text);
            komut.Parameters.AddWithValue("@k4", txtSaat.Text);
            komut.Parameters.AddWithValue("@k5", txtKoltukSayisi.Text);
            komut.Parameters.AddWithValue("@k6", txtFiyat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Uçuş Eklendi.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Formu kapattıktan sonra program arkada çalışmaya devam ettiği için uygulamayı kapat butonu koydum ve program tamamen sonlandı.
            MessageBox.Show("Çıkış Yapıyorsunuz.");
            Application.Exit();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //calisan paneline geri döndük.
            CalisanPaneli calisan = new CalisanPaneli();
            calisan.Show();
            Close();
        }

        private void UcusEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
