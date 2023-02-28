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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ThyOnlineBiletSatis
{
    public partial class UcusSil : Form
    {
        public UcusSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=ThyOnlineBiletSatis;Integrated Security=True");//Sql baglanti

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //Ucus aramak icin sorgumuzu kriterlere göre yazdık ve calistirdik.
            SqlCommand komut = new SqlCommand("Select * from Ucuslar where Nereden like '%" + comboBoxNereden.Text + "%' and Nereye like '%" + comboBoxNereye.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet dt = new DataSet(); 
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            baglanti.Close();
        }

        private void UcusSil_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
                baglanti.Open();
                //Ucus silmek icin sorgumuzu belirli kritlerle göre yazdik ve calistirdik.
                SqlCommand sil = new SqlCommand("delete from Ucuslar where  Nereden like  '%" + textBoxNereden.Text + "%' and Nereye like '%"+textBoxNereye.Text+"%' and Tarih like  '%"+textBoxTarih.Text+"%' and Saat like '%"+textBoxSaat.Text+ "%' and Ucus_ID like '%"+txtUcus_Id.Text+"%'", baglanti);
                sil.ExecuteNonQuery();
                MessageBox.Show("Basariyla silindi!");
                baglanti.Close();
            
                
            

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
         
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış Yapıyorsunuz.");
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //aradigimiz ucuslari datagridview de listeledik
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtUcus_Id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBoxNereden.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBoxNereye.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBoxTarih.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBoxSaat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            //calisan formuna geri döndük.
            CalisanPaneli calisan = new CalisanPaneli();
            calisan.Show();
            Close();
        }
    }
}
