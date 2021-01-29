using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cv_Blok
{
    public partial class AdminEgitimSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["id"]);

            DataSet1TableAdapters.Tbl_EgitimTableAdapter dt = new DataSet1TableAdapters.Tbl_EgitimTableAdapter();

            dt.EgitimSil(Convert.ToInt16(x));

            Response.Redirect("AdminEgitim.aspx");
        }
    }
}