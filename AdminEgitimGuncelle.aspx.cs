using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cv_Blok
{
    public partial class AdminEgitimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int i = Convert.ToInt16(Request.QueryString["id"]);
                Txtid.Text = i.ToString();
                Txtid.Enabled = false;

                DataSet1TableAdapters.Tbl_EgitimTableAdapter dt = new DataSet1TableAdapters.Tbl_EgitimTableAdapter();
                TxtBaslik.Text = dt.EgitimGetir(Convert.ToInt16(i))[0].Baslik;
                TxtAltBaslik.Text = dt.EgitimGetir(Convert.ToInt16(i))[0].AltBaslik;
                TxtAciklama.Text = dt.EgitimGetir(Convert.ToInt16(i))[0].Aciklama;
                TxtGnot.Text = dt.EgitimGetir(Convert.ToInt16(i))[0].Gnot;
                TxtTarih.Text = dt.EgitimGetir(Convert.ToInt16(i))[0].Tarih;

            }
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_EgitimTableAdapter db = new DataSet1TableAdapters.Tbl_EgitimTableAdapter();
            db.EgitimGuncelle(TxtBaslik.Text, TxtAltBaslik.Text, TxtAciklama.Text, TxtGnot.Text, TxtTarih.Text, Convert.ToInt16(Txtid.Text));
            Response.Redirect("AdminEgitim.aspx");
        }
    }
}