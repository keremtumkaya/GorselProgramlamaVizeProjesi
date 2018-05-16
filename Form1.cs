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
    public partial class Form1 : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-VKG56TO\\SQLEXPRESS;Initial Catalog=siteler;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sql = "SELECT * FROM admin where kullaniciAdi=@kAdi AND  sifre=@adminsifre";
                SqlParameter prm1 = new SqlParameter("kAdi", textBox1.Text.Trim());
                SqlParameter prm2 = new SqlParameter("adminsifre", textBox2.Text.Trim());
                SqlCommand komut = new SqlCommand(sql,baglan);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Form2 fr = new Form2();
                    fr.Show();
                    
                }
            }
            catch (Exception)
            {

                MessageBox.Show("hatalı giriş");
            }
        }
    }
}
