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
    public partial class UcusSilAdmin : Form
    {
        public UcusSilAdmin()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=ThyOnlineBiletSatis;Integrated Security=True");//Sql baglanti
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //veritabanindan arayacagimiz ucuslar icin select sorgusu oluşturduk ve datagridview e yazdirdik 
            SqlCommand komut = new SqlCommand("Select * from Ucuslar where Nereden like '%" + comboBoxNereden.Text + "%' and Nereye like '%" + comboBoxNereye.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //datagridview den sectigimiz verileri veri tabanından sildik.
            SqlCommand sil = new SqlCommand("delete from Ucuslar where  Nereden like  '%" + txtNereden.Text + "%' and Nereye like '%" + txtNereye.Text + "%' and Tarih like  '%" + txtTarih.Text + "%' and Saat like '%" + txtSaat.Text + "%' and Ucus_ID like '%" + txtUcus_Id.Text + "%'", baglanti);
            sil.ExecuteNonQuery();
            MessageBox.Show("Basariyla silindi!");
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //arama sonucumuzu datagridview e yazdirdik.
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtUcus_Id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtNereden.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtNereye.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtTarih.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSaat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void UcusSilAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Bir önceki forma geri dönüş yaptik
            UcusEkleSilVeyaGörüntüle ucusEkleSilVeyaGörüntüle = new UcusEkleSilVeyaGörüntüle();
            ucusEkleSilVeyaGörüntüle.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Çıkış Yapıyorsunuz.");
            Application.Exit();//Formu kapattıktan sonra program arkada çalışmaya devam ettiği için uygulamayı kapat butonu koydum ve program tamamen sonlandı.
        }
    }
}
