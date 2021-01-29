using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cv_Blok
{
    public partial class AdminKonferansSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["id"]);

            DataSet1TableAdapters.Tbl_KonferanslarTableAdapter dt = new DataSet1TableAdapters.Tbl_KonferanslarTableAdapter();
            dt.KonferansSil(Convert.ToInt16(x));

            Response.Redirect("AdminKonferans.aspx");
        }
    }
}