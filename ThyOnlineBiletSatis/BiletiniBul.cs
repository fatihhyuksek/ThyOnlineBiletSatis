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

namespace ThyOnlineBiletSatis
{
    public partial class BiletiniBul : Form
    {
        public BiletiniBul()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=ThyOnlineBiletSatis;Integrated Security=True");//Sql Baglanti
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BiletiniBul_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;//Biletini Seçmeden önce seçtiğiniz bilet kısmını göstermedim.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Select sorgusuyla gerekli bilgileri TC ŞARTIYLA ALDIK
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tbl_SatilanBiletler where TC like '%" + txtTC.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
                //seçtiğimiz bileti delete komutu ile veritabanımızdn sildik.
                baglanti.Open();
                SqlCommand sil = new SqlCommand("delete from tbl_SatilanBiletler where  TC like  '%" + lblTc.Text + "%' and İsim like '%" + lblİsim.Text + "%' and Soyisim like  '%" + lblSoyisim.Text + "%' and Nereden like '%" + lblNereden.Text + "%' and Nereye like '%" + lblNereye.Text + "%' and Tarih like '%" + lblTarih.Text + "%' and Saat like '%" + txtSaat.Text + "%'and Fiyat like  '%" + lblFiyat.Text + "%'and Adet like  '%" + lblAdet.Text + "%'", baglanti);
                sil.ExecuteNonQuery();
                MessageBox.Show("Biletiniz İade Edildi");
                baglanti.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;//Biletini sectikten groupboxı aktif edip seçtiği bile gösterdik
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            labelUcusID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            lblTc.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            lblİsim.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            lblSoyisim.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            lblNereden.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            lblNereye.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            lblTarih.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSaat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            lblFiyat.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            lblAdet.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tekrar Bekleriz.");
            Application.Exit();//Formu kapattıktan sonra program arkada çalışmaya devam ettiği için uygulamayı kapat butonu koydum ve program tamamen sonlandı.

        }

        private void txtTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
