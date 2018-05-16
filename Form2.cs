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


namespace SiteEmlakTakibi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
    
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-VKG56TO\\SQLEXPRESS;Initial Catalog=siteler;Integrated Security=True");
        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From sitebilgi", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["site"].ToString());
                ekle.SubItems.Add(oku["oda"].ToString());
                ekle.SubItems.Add(oku["metre"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["blok"].ToString());
                ekle.SubItems.Add(oku["no"].ToString());
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["notlar"].ToString());
                ekle.SubItems.Add(oku["satkira"].ToString());

                listView1.Items.Add(ekle);
              
            }
            baglan.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbsite.Text== "Zambak Sitesi")
            {
                btnzambak.BackColor = Color.Yellow;
                btngul.BackColor = Color.Gray;
                btnmenekse.BackColor = Color.Gray;
                btnpapatya.BackColor = Color.Gray;

            }
            if (cmbsite.Text == "Gül Sitesi")
            {
                btnzambak.BackColor = Color.Gray;
                btngul.BackColor = Color.Yellow;
                btnmenekse.BackColor = Color.Gray;
                btnpapatya.BackColor = Color.Gray;

            }
            if (cmbsite.Text == "Papatya Sitesi")
            {
                btnzambak.BackColor = Color.Gray;
                btngul.BackColor = Color.Gray;
                btnmenekse.BackColor = Color.Gray;
                btnpapatya.BackColor = Color.Yellow;

            }
            if (cmbsite.Text == "Menekşe Sitesi")
            {
                btnzambak.BackColor = Color.Gray;
                btngul.BackColor = Color.Gray;
                btnmenekse.BackColor = Color.Yellow;
                btnpapatya.BackColor = Color.Gray;

            }
        }

       

        private void btngoruntule_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand komut = new SqlCommand("Insert INTO sitebilgi (site,oda,metre,fiyat,blok,no,adsoyad,telefon,notlar,satkira) values ('" + cmbsite.Text.ToString()+"','"+cmboda.Text.ToString()+"' ,'"+txtmetre.Text.ToString() + "','" + txtfiyat.Text.ToString() + "','" + cmbblok.Text.ToString() + "','" + txtno.Text.ToString() + "','" + txtad.Text.ToString() + "','" + txttel.Text.ToString() + "','" + txtnot.Text.ToString() + "','" + cmbsat.Text.ToString() + "')",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
        }

        int id = 0;
        private void btnsil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM sitebilgi WHERE id=("+id+")",baglan);

            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtid.Text=listView1.SelectedItems[0].SubItems[0].Text;
            cmbsite.Text = listView1.SelectedItems[0].SubItems[1].Text;
            cmboda.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtmetre.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtfiyat.Text = listView1.SelectedItems[0].SubItems[4].Text;
            cmbblok.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtno.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtad.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txttel.Text = listView1.SelectedItems[0].SubItems[8].Text; 
            txtnot.Text = listView1.SelectedItems[0].SubItems[9].Text;
            cmbsat.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void btnduzelt_Click(object sender, EventArgs e)
        {
            baglan.Open();
           SqlCommand komut = new SqlCommand("UPDATE sitebilgi SET site='" + cmbsite.Text.ToString() + "',oda='" + cmboda.Text.ToString() + "' ,metre='" + txtmetre.Text.ToString() + "',fiyat='" + txtfiyat.Text.ToString() + "',blok='" + cmbblok.Text.ToString() + "',no='" + txtno.Text.ToString() + "',adsoyad='" + txtad.Text.ToString() + "',telefon='" + txttel.Text.ToString() + "',notlar='" + txtnot.Text.ToString() + "',satkira='" + cmbsat.Text.ToString() + "' WHERE id="+id+"", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult tus;
            tus = MessageBox.Show("çıkmak istediğinizen emin misiniz ?", "soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tus== DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
