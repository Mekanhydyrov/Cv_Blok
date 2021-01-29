using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cv_Blok.Admin
{
    public partial class Hakkimda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                //Hkkimda Textbox Yazdırma
                DataSet1TableAdapters.Tbl_HakkimdaTableAdapter dt = new DataSet1TableAdapters.Tbl_HakkimdaTableAdapter();
                TextBox1.Text = dt.HakkimdaListele()[0].Ad;
                TextBox2.Text = dt.HakkimdaListele()[0].Soyad;
                TextBox3.Text = dt.HakkimdaListele()[0].Adres;
                TextBox4.Text = dt.HakkimdaListele()[0].Telefon;
                TextBox5.Text = dt.HakkimdaListele()[0].Mail;
                TextBox6.Text = dt.HakkimdaListele()[0].KisaNot;
                TextBox7.Text = dt.HakkimdaListele()[0].Fotograf;
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_HakkimdaTableAdapter dt1 = new DataSet1TableAdapters.Tbl_HakkimdaTableAdapter();
            dt1.HakkimdaGuncelle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text);
            Response.Redirect("AnaSayfa.aspx");
        }
    }
}