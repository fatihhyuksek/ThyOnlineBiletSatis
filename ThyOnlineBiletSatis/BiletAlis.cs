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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Common;

namespace ThyOnlineBiletSatis
{
    public partial class BiletAlis : Form
    {
        SqlDataReader dr;
        public bool ButonaTiklandiMi=false;//kaydet işlemini yaptıktan sonra satın ala basmadan bilet alındı gibi gözükmesin diye bool değişkeni kullandım.
        public BiletAlis()
        {
            InitializeComponent();

        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=ThyOnlineBiletSatis;Integrated Security=True");//Sql baglantisi



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ButonaTiklandiMi = true;//butona tıklandıktan sonra bool değişkenini true yaptık.

            
                baglanti.Open();
                try
                {
                    //Bilet alındıktan sonra koltuk sayımızı azaltmak için sp kullandım ve update edip koltuk sayısını 1 azalltıım
                    string prosedür3 = "CREATE PROCEDURE up_KoltukSayısınıAzalt @Nereden varchar(50),@Nereye varchar(50),@Tarih varchar(50),@Saat time(0)  AS BEGIN Update Ucuslar set Koltuk_Sayısı=Koltuk_Sayısı-1  where  Nereden like '%" + lblNereden.Text + "%' and Nereye like '%" + lblNereye.Text + "%' and Tarih like '%" + lblTarih.Text + "%' and Saat like '%" + labelSaat.Text + "%'END";
                    SqlCommand prosedür = new SqlCommand(prosedür3, baglanti);
                    prosedür.ExecuteNonQuery();


                }
                catch
                {

                }
                baglanti.Close();

                baglanti.Open();
                string komut2 = "exec up_KoltukSayısınıAzalt  @k1,@k2,@k3,@k4";//sp yi burda çağırdık.
                SqlCommand islem = new SqlCommand(komut2, baglanti);
                islem.Parameters.AddWithValue("@k1", lblNereden.Text);
                islem.Parameters.AddWithValue("@k2", lblNereye.Text);
                islem.Parameters.AddWithValue("@k3", lblTarih.Text);
                islem.Parameters.AddWithValue("@k4", labelSaat.Text);

                SqlDataReader dr = islem.ExecuteReader();
                MessageBox.Show("Biletinizi Aldınız");
                baglanti.Close();
                if (ButonaTiklandiMi==true)
                {
                //Eğer butona tıklandımı şartımız gerçekleştiyse aldığımzı kayıtları database e kaydettik.
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into Tbl_SatilanBiletler(Nereden,Nereye,Tarih,Saat,Fiyat,Adet,TC,İsim,Soyisim,Telefon,Mail,Ucus_ID)values (@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10,@a11,@a12)", baglanti);
                    komut.Parameters.AddWithValue("@a1", lblNereden.Text);
                    komut.Parameters.AddWithValue("@a2", lblNereye.Text);
                    komut.Parameters.AddWithValue("@a3", lblTarih.Text);
                    komut.Parameters.AddWithValue("@a4", labelSaat.Text);
                    komut.Parameters.AddWithValue("@a5", labelÜcret.Text);
                    komut.Parameters.AddWithValue("@a6", txtAdet.Text);
                    komut.Parameters.AddWithValue("@a7", txtTc.Text);
                    komut.Parameters.AddWithValue("@a8", txtİsim.Text);
                    komut.Parameters.AddWithValue("@a9", txtSoyisim.Text);
                    komut.Parameters.AddWithValue("@a10", txtTelefon.Text);
                    komut.Parameters.AddWithValue("@a11", txtMail.Text);
                    komut.Parameters.AddWithValue("@a12", labelUcusID.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                 }
                



            
             
           


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void BiletAlis_Load(object sender, EventArgs e)
        {


        }

        private void txtKoltukSayisi_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           //Uçak bileti alabilmek için gerekli bilgileri girdi mi diye kontrol ettik.
            if (String.IsNullOrEmpty(txtTc.Text) || String.IsNullOrEmpty(txtİsim.Text) || String.IsNullOrEmpty(txtSoyisim.Text) || String.IsNullOrEmpty(txtTelefon.Text) || String.IsNullOrEmpty(txtMail.Text))
            {
                MessageBox.Show("Kullanici Bilgileri boş geçilemez");
            }
            //Uçak bileti alabilmek için gerekli olan TC VE TELEFON bilgisini dogru girdi mi diye kontrol ettik
            else if (txtTc.Text.Length!=11 || txtTelefon.Text.Length!=10)
            {
                MessageBox.Show("TC nizi veya telefon numaranızı eksik tuşladınız lütfen tekrar giriniz.");
            }
            // Diğer şartlar sağlandığında satin al butonunu tıklayabilir yaptık.
            else
            {
                btnSatinAl.Enabled = true;
                MessageBox.Show("Kayıt Eklendi.");
            }
           

              
                    
                
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tekrar Bekleriz.");
            Application.Exit();//Uygulamayı tamamen kapanması için buton koyduk aksi takdirde uygulama arka planda çalışmaya devam edecek.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
