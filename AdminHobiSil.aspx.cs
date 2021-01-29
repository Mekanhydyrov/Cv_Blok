using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cv_Blok
{
    public partial class AdminHobiSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(Request.QueryString["id"]);

            DataSet1TableAdapters.Tbl_HobilerTableAdapter dt = new DataSet1TableAdapters.Tbl_HobilerTableAdapter();
            dt.HobiSil(Convert.ToInt16(i));

            Response.Redirect("AdminHobi.aspx");
        }
    }
}