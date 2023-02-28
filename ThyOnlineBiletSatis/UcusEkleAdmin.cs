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
    public partial class UcusEkleAdmin : Form
    {
        public UcusEkleAdmin()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=ThyOnlineBiletSatis;Integrated Security=True");//Sql baglanti
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //Calisan panelinde ucus eklemek icin yazdıgımız sp yi burda da calistirdik
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

        private void button4_Click(object sender, EventArgs e)
        {
            //Bir önceki forma geri döndük
            UcusEkleSilVeyaGörüntüle ucusEkleSilVeyaGörüntüle = new UcusEkleSilVeyaGörüntüle();
            ucusEkleSilVeyaGörüntüle.Show();
            Close();
        }

        private void UcusEkleAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış Yapıyorsunuz.");
            Application.Exit();//Formu kapattıktan sonra program arkada çalışmaya devam ettiği için uygulamayı kapat butonu koydum ve program tamamen sonlandı.
        }
    }
}
