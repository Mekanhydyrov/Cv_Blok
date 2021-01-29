using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cv_Blok
{
    public partial class AdminKonferans : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_KonferanslarTableAdapter dt = new DataSet1TableAdapters.Tbl_KonferanslarTableAdapter();
            Repeater1.DataSource = dt.KonferansListesi();
            Repeater1.DataBind();
        }
    }
}