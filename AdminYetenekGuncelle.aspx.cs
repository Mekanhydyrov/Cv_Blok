using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cv_Blok
{
    public partial class AdminYetenekGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int i = Convert.ToInt16(Request.QueryString["id"]);
                Txtid.Text = i.ToString();
                Txtid.Enabled = false;

                DataSet1TableAdapters.Tbl_YeteneklerTableAdapter dt = new DataSet1TableAdapters.Tbl_YeteneklerTableAdapter();
                TxtBaslik.Text = dt.YetenekGetir(Convert.ToInt16(i))[0].Baslik;
                TxtYetenek.Text = dt.YetenekGetir(Convert.ToInt16(i))[0].Yetenek;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_YeteneklerTableAdapter db = new DataSet1TableAdapters.Tbl_YeteneklerTableAdapter();
            db.YetenekGuncelle(TxtBaslik.Text, TxtYetenek.Text, Convert.ToInt16(Txtid.Text));

            Response.Redirect("AdminYetenek.aspx");
        }
    }
}