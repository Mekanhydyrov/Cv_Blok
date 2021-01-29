using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cv_Blok
{
    public partial class AdminYenetekEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnYetenekEkle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_YeteneklerTableAdapter dt = new DataSet1TableAdapters.Tbl_YeteneklerTableAdapter();
            dt.YetenekEkle(TxtBaslik.Text, TxtYetenek.Text);

            Response.Redirect("AdminYetenek.aspx");
        }
    }
}