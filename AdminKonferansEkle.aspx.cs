using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cv_Blok
{
    public partial class AdminKonferansEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnKonferansEkle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_KonferanslarTableAdapter dt = new DataSet1TableAdapters.Tbl_KonferanslarTableAdapter();
            dt.KonferansEkle(TxtKonferans.Text);

            Response.Redirect("AdminKonferans.aspx");
        }
    }
}