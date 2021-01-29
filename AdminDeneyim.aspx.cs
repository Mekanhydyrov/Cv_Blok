using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cv_Blok
{
    public partial class AdminDeneyim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_DeneyimTableAdapter dt = new DataSet1TableAdapters.Tbl_DeneyimTableAdapter();
            Repeater1.DataSource = dt.DeneyimListesi();
            Repeater1.DataBind();
        }
    }
}