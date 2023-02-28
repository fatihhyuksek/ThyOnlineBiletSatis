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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ThyOnlineBiletSatis
{
    public partial class KullaniciPaneli : Form
    {
        SqlCommand komut;
        SqlDataReader dr;
        SqlConnection baglanti;
        DataSet ds = new DataSet();
        public string[] items = new string[7];//listview girilen değerleri vermek  için dizi oluşturduk
        public KullaniciPaneli()
        {
            InitializeComponent();
            //Listview in satır boyutlarını ve adlarını belirledik
            listView1.Columns.Add("Ucus_ID", 120);
            listView1.Columns.Add("Nerden", 120);
            listView1.Columns.Add("Nereye", 120);
            listView1.Columns.Add("Tarih", 120);
            listView1.Columns.Add("Saat", 120);
            listView1.Columns.Add("Koltuk Sayısı", 120);
            listView1.Columns.Add("Ücret", 120);
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            string Nereden = comboBoxNereden.Text;
            string Nereye = comboBoxNereye.Text;
            string Tarih = maskedTextBox1.Text;
            string Fiyat = items[5];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            listView1.Items.Clear();
            string Nereden = comboBoxNereden.Text;
            string Nereye = comboBoxNereye.Text;
            string Tarih = maskedTextBox1.Text;
            string Fiyat = items[5];
            string KoltukSayisi = items[4];
            string Saat = items[3];
        
            baglanti = new SqlConnection("Data Source=.;Initial Catalog=ThyOnlineBiletSatis;Integrated Security=True");//Sql baglanti
            baglanti.Open();
            //select sorgusuyla uçuş arattık.
            SqlCommand komut = new SqlCommand("Select * from Ucuslar where Nereden like '%" + comboBoxNereden.Text + "%' and Nereye like '%" + comboBoxNereye.Text+ "%' and Tarih like '%" + maskedTextBox1.Text + "%'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                //veritabanından verileri okuduk ve listview e attık.
                DateTime date1;
                DateTime.TryParse(dr["tarih"].ToString(), out date1);
                items[0] = dr["Ucus_ID"].ToString();
                items[1] = dr["Nereden"].ToString();
                items[2] = dr["Nereye"].ToString();
                items[3] = date1.ToString("dd/MM/yyyy");
                items[4] = dr["Saat"].ToString();
                items[5] = dr["Koltuk_Sayısı"].ToString();
                items[6] = dr["Fiyat"].ToString();
                ListViewItem listViewItem = new ListViewItem(items);
                listView1.Items.Add(listViewItem);

               


                
            }
            int i= 0;
            for( i =0; i < 1; i++)
            {
                //uçuş aramasında gerekli kontorlleri sağladık
                if ((items[1] != comboBoxNereden.Text) || (items[2] != comboBoxNereye.Text) || (items[3] != maskedTextBox1.Text) || (items[5] == "0"))
                {
                    MessageBox.Show("Uçuş bulunamadı");
                    button2.Enabled = false;
                }
                else if ((items[1] == comboBoxNereden.Text) && (items[2] == comboBoxNereye.Text) && (items[3] == maskedTextBox1.Text) && (items[5]!="0"))
                {
                    MessageBox.Show("Uçuş bulundu");
                    button2.Enabled = true;
                }
               
            }
            i= 0;


            baglanti.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)

            {



                listView1.Items[i].Checked = true;
               
            }
            if (listView1.SelectedItems.Count > 0)

            {
                //Listview e diziye attığımız verileri yazdırdık

                ListViewItem item = listView1.SelectedItems[0];

                txtNereden.Text = item.SubItems[1].Text;

                txtNereye.Text = item.SubItems[2].Text;

                txtTarih.Text = item.SubItems[3].Text;

                txtKoltukSayisi.Text = item.SubItems[5].Text;

                txtFiyat.Text = item.SubItems[6].Text;

                txtSaat.Text = item.SubItems[4].Text;

                txtUcus_Id.Text = item.SubItems[0].Text;



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                //formlar arası veri aktardık.
                BiletAlis f5 = new BiletAlis();
                f5.lblNereden.Text = txtNereden.Text;
                f5.lblNereye.Text = txtNereye.Text;
                f5.lblTarih.Text = txtTarih.Text;
                f5.labelKoltukSayısı.Text= txtKoltukSayisi.Text;
                f5.labelÜcret.Text = txtFiyat.Text;
                f5.labelSaat.Text = txtSaat.Text;
                f5.labelUcusID.Text = txtUcus_Id.Text;
                f5.Show();
               





        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //geri dön butonuyla çıkış yaptık.
            MessageBox.Show("Çıkış Yapıyorsunuz.");
            GirisPaneli giris = new GirisPaneli();
            giris.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tekrar Bekleriz.");
            Application.Exit();//Formu kapattıktan sonra program arkada çalışmaya devam ettiği için uygulamayı kapat butonu koydum ve program tamamen sonlandı.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //bilet sorgulama formuna geçtik
            BiletiniBul bilet = new BiletiniBul();
            bilet.Show();
            
        }

        private void KullaniciPaneli_Load(object sender, EventArgs e)
        {

        }
    }
}
