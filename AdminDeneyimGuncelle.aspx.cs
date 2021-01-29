using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cv_Blok
{
    public partial class AdminDeneyimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int x = Convert.ToInt16(Request.QueryString["id"]);
            Txtid.Text = x.ToString();
            Txtid.Enabled = false;
   
            DataSet1TableAdapters.Tbl_DeneyimTableAdapter dt = new DataSet1TableAdapters.Tbl_DeneyimTableAdapter();
            TxtBaslik.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].Baslik;
            TxtAltBasik.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].AltBaslik;
            TxtAciklama.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].Aciklama;
            TxtTarih.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].Tarih;
            }
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_DeneyimTableAdapter db = new DataSet1TableAdapters.Tbl_DeneyimTableAdapter();
            db.DeneyimGuncelle(TxtBaslik.Text,TxtAltBasik.Text,TxtAciklama.Text,TxtTarih.Text, Convert.ToInt16(Txtid.Text));

        }
    }
}