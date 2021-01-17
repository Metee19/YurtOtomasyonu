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
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try { 
            SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd=@p2,OgrSoyad=@p3,OgrTc=@p4,OgrTelefon=@p5,OgrDogum=@p6,OgrBolum=@p7,OgrMail=@p8,OgrenciOdaNo=@p9,OgrVeliAdSoyad=@p10,OgrVeliTelefon=@p11,OgrVeliAdres=@p12 where Ogrid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtOgrid.Text);
            komut.Parameters.AddWithValue("@p2", TxtOgrAd.Text);
            komut.Parameters.AddWithValue("@p3", TxtOgrSoyad.Text);
            komut.Parameters.AddWithValue("@p4", MskTc.Text);
            komut.Parameters.AddWithValue("@p5", MskOgrTelefon.Text);
            komut.Parameters.AddWithValue("@p6", MskDogum.Text);
            komut.Parameters.AddWithValue("@p7", CmbBolum.Text);
            komut.Parameters.AddWithValue("@p8", TxtMail.Text);
            komut.Parameters.AddWithValue("@p9", CmbOdaNo.Text);
            komut.Parameters.AddWithValue("@p10", TxtVeliAdSoyad.Text);
            komut.Parameters.AddWithValue("@p11", MskVeliTelefon.Text);
            komut.Parameters.AddWithValue("@p12", RchAdres.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi");
                foreach (Control item in Controls) //bütün nesnelerini kontrol eder
                {
                    if (item is TextBox || item is ComboBox || item is MaskedTextBox || item is RichTextBox) //nesneler formdaki nesneler  ise
                    {
                        item.Text = ""; //textlerini "" yani boş yapar
                    }
                }
            }
           
            catch
            {
                MessageBox.Show("Hata!!! Tekrar deneyiniz");
            }
        }

        public string id, ad, soyad, TC, telefon, dogum, bolum;

        private void btnSil_Click(object sender, EventArgs e)
        {
            //Öğrenci Silme Komutları
            SqlCommand komutsil = new SqlCommand("delete from Ogrenci where Ogrid=@k1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@k1", TxtOgrid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi");

            //Oda Aktif Öğrenci Sayısını Azaltma
            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif-1 where OdaNo=@oda", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda", CmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();

            foreach (Control item in Controls) //bütün nesnelerini kontrol eder
            {
                if (item is TextBox || item is ComboBox || item is MaskedTextBox || item is RichTextBox) //nesneler formdaki nesneler  ise
                {
                    item.Text = ""; //textlerini "" yani boş yapar
                }
            }

        }

        public string mail, odano, veliadsoyad, velitel, veliadres;

        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            TxtOgrid.Text = id;
            TxtOgrAd.Text = ad;
            TxtOgrSoyad.Text = soyad;
            MskTc.Text = TC;
            MskOgrTelefon.Text = telefon;
            MskDogum.Text = dogum;
            CmbBolum.Text = bolum;
            TxtMail.Text = mail;
            CmbOdaNo.Text = odano;
            TxtVeliAdSoyad.Text = veliadsoyad;
            MskVeliTelefon.Text = velitel;
            RchAdres.Text = veliadres;
        }
    }
}
