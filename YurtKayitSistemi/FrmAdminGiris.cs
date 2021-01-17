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
namespace YurtKayitSistemi
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            //Girilen bilgileri veritabanındaki bilgilerle eşleştirip giriş yapma işlemini sağlayan kod blokları
            SqlCommand komut = new SqlCommand("select * from Admin where YoneticiAd=@p1 and YoneticiSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullanıcıAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre Girdiniz Lütfen Tekrar Deneyiniz");
                TxtKullanıcıAd.Clear();
                TxtSifre.Clear();
                TxtKullanıcıAd.Focus();
            }
            bgl.baglanti().Close();
        }
    }
}
//foreach (Control item in Controls) //bütün nesnelerini kontrol eder
//{
//    if (item is TextBox || item is ComboBox || item is MaskedTextBox || item is RichTextBox) //nesneler formdaki nesneler  ise
//    {
//        item.Text = ""; //textlerini "" yani boş yapar
//    }
//}