using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cv_Blok
{
    public partial class AdminSifre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.Tbl_AdminTableAdapter dt = new DataSet1TableAdapters.Tbl_AdminTableAdapter();
              
                TxtKullanici.Text = dt.AdminListele()[0].Kullanici;
                TxtSifre.Text = dt.AdminListele()[0].Sifre;

            }
        }

        protected void Btn_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_AdminTableAdapter dt = new DataSet1TableAdapters.Tbl_AdminTableAdapter();
            dt.AdminGuncelle(TxtKullanici.Text, TxtSifre.Text);

            Response.Redirect("Hakkimda.aspx");
        }
    }
}