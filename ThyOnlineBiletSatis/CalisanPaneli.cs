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
    public partial class CalisanPaneli : Form
    {
        public CalisanPaneli()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=ThyOnlineBiletSatis;Integrated Security=True");//Sql baglanti

        private void btnUcusEkle_Click(object sender, EventArgs e)
        {
            //Calisan paneline yeni ucus ekleyebilsin diye yeni forma geçiş yaptık.
            UcusEkle ucus =new UcusEkle();
            ucus.Show();
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView1.Visible = true;
            baglanti.Open();
            try
            {
                // sp oluşturup bütün biletleri listeledik.
                string prosedür5= "CREATE PROCEDURE up_BütünBiletleriListele  AS BEGIN Select * from Ucuslar END";
                SqlCommand prosedür = new SqlCommand(prosedür5,baglanti);
                prosedür.ExecuteNonQuery();

            }
            catch
            {

            }
            //sp yi çalıştırdık.
            SqlCommand komut = new SqlCommand(" exec up_BütünBiletleriListele ", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];



            baglanti.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış Yapıyorsunuz.");
            Application.Exit();//Formu kapattıktan sonra program arkada çalışmaya devam ettiği için uygulamayı kapat butonu koydum ve program tamamen sonlandı.



        }

        private void CalisanPaneli_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            // bir önceki forma geri döndük.
            MessageBox.Show("Uygulamayı Kapatıyorsunuz.");
            GirisPaneli giris = new GirisPaneli();
            giris.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //ucus silmek için yeni form oluşturduk
            UcusSil sil = new UcusSil();
            sil.Show();
            Close();
         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
