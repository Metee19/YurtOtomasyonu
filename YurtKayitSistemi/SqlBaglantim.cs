using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace YurtKayitSistemi
{
   public class SqlBaglantim
    {
        //Her seferinde baglanti açmamak için bir tane baglantı Classı oluşturdum ondan nesne üretip  
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-RIUMMH5\SQLEXPRESS;Initial Catalog=YurtKayit;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
