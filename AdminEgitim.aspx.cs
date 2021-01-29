using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cv_Blok
{
    public partial class AdminEgitim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_EgitimTableAdapter dt = new DataSet1TableAdapters.Tbl_EgitimTableAdapter();
            Repeater1.DataSource = dt.EgitimListesi();
            Repeater1.DataBind();

        }
    }
}