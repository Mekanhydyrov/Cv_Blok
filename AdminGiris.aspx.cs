using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Cv_Blok
{
    public partial class AdminGiris : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-V97H4S3\SQLEXPRESS;Initial Catalog=Db_Cv_Blok;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Admin Where Kullanici=@p1 and Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtKullanici.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                Response.Redirect("Hakkimda.aspx");
            }
            else
            {
                Response.Write("Kullanıcı Adı Yada Şife Hatalı !");
            }
        }
    }
}