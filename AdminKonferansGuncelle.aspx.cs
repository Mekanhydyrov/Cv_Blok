using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cv_Blok
{
    public partial class AdminKonferansGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["id"]);
            Txtid.Text = x.ToString();
            Txtid.Enabled = false;

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.Tbl_KonferanslarTableAdapter dt = new DataSet1TableAdapters.Tbl_KonferanslarTableAdapter();
                TxtKonferans.Text = dt.KonferansGetir(Convert.ToInt16(x))[0].Konferans;
            }    
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_KonferanslarTableAdapter dt = new DataSet1TableAdapters.Tbl_KonferanslarTableAdapter();
            dt.KonferansGuncelle(TxtKonferans.Text, Convert.ToInt16(Txtid.Text));

            Response.Redirect("AdminKonferans.aspx");
        }
    }
}