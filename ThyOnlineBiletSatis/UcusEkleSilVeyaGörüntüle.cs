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
    public partial class UcusEkleSilVeyaGörüntüle : Form
    {
        public UcusEkleSilVeyaGörüntüle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=ThyOnlineBiletSatis;Integrated Security=True");//sql baglanti

        private void button1_Click(object sender, EventArgs e)
        {
            //Ucus ekleme admin formuna gectik
            UcusEkleAdmin ucusEkleAdmin = new UcusEkleAdmin();
            ucusEkleAdmin.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            baglanti.Open();
            //Ucusları Görüntülemek için yazdigimiz sp yi burda da calistirdik.
            SqlCommand komut = new SqlCommand(" exec up_BütünBiletleriListele ", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];



            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // ucus sil admin formuna gectik
            UcusSilAdmin ucusSilAdmin = new UcusSilAdmin();
            ucusSilAdmin.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Çıkış Yapıyorsunuz.");
            Application.Exit();//Formu kapattıktan sonra program arkada çalışmaya devam ettiği için uygulamayı kapat butonu koydum ve program tamamen sonlandı.
        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            //admin paneline geri döndük
            AdminPaneli admin = new AdminPaneli();
            admin.Show();
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UcusEkleSilVeyaGörüntüle_Load(object sender, EventArgs e)
        {

        }
    }
}
