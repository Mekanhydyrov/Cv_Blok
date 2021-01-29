using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cv_Blok
{
    public partial class AdminEgitimEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEgitimEkle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_EgitimTableAdapter dt = new DataSet1TableAdapters.Tbl_EgitimTableAdapter();

            dt.EgitimEkle(TxtAltBaslik.Text,TxtAltBaslik.Text,TxtAciklama.Text,TxtGnot.Text,TxtTarih.Text);

            Response.Redirect("AdminEgitim.aspx");
        }
    }
}