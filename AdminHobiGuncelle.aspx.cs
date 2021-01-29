using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cv_Blok
{
    public partial class AdminHobiGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(Request.QueryString["id"]);
            Txtid.Text = i.ToString();
            Txtid.Enabled = false;

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.Tbl_HobilerTableAdapter dt = new DataSet1TableAdapters.Tbl_HobilerTableAdapter();
                TxtHobi.Text = dt.HobiGetir(Convert.ToInt16(i))[0].Hobi;
            }      
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_HobilerTableAdapter dt = new DataSet1TableAdapters.Tbl_HobilerTableAdapter();
            dt.HobiGuncelle(TxtHobi.Text, Convert.ToInt16(Txtid.Text));

            Response.Redirect("AdminHobi.aspx");
        }
    }
}