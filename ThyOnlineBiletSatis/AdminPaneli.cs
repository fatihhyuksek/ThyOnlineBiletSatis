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
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=ThyOnlineBiletSatis;Integrated Security=True");//Sql ile bağlanti

        private void button1_Click(object sender, EventArgs e)
        {
            CalisanEkle calisan = new CalisanEkle();// Calisan ekle butonuna tıklandığında yeni bi form açtık.
            calisan.Show();
            Close();

        }

        private void AdminPaneli_Load(object sender, EventArgs e)
        {
            btnkapat.Visible = false;// data grid wiev i açtıktan sonra kapatabiliceğimiz butonun ilk başta göstermedik
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            btnkapat.Visible = true;// data grid wiev i açtıktan sonra kapatabiliceğimiz butonu gösterdik.
            baglanti.Open();//baglantiyi açtık
            SqlCommand komut = new SqlCommand("Select SatilanBiletSayisi,ToplamKazanc,AktifUcusSayisi from Tbl_ToplamSatilanBiletSayisi  ", baglanti);//Select sorgusuyla listeleyeceğimiz yerleri aldık
            
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            baglanti.Close(); //baglantiyi açtık
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış Yapıyorsunuz.");// geri dönüş butonuna tıklandıktan sonra çıkış yapıyoruz ve bir önceki panele dönüş yapıyoruz.
            GirisPaneli giris = new GirisPaneli();
            giris.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulamayı Kapatıyorsunuz.");
            Application.Exit();// formları kapatsakta arka planda açık kalabildiği için uygulamayı tamamen kapatmak için butona tıkladığımızda uygulama tamamen kapanıyor.

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible=false;// datagridwiev i listeledikten sonra butona bastığımızda geri kapattık.
            btnkapat.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            UcusEkleSilVeyaGörüntüle ucusEkleVeyaGörüntüle = new UcusEkleSilVeyaGörüntüle();
            ucusEkleVeyaGörüntüle.Show(); // Uçuş ekle sil veya görüntüleme butonuna tıkladığımızda yeni forma yolladık.
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
