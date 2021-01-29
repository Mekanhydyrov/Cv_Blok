using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cv_Blok
{
    public partial class AnaSayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Hakkımızda Kısmını Listeleme
            DataSet1TableAdapters.Tbl_HakkimdaTableAdapter db = new DataSet1TableAdapters.Tbl_HakkimdaTableAdapter();
            Repeater1.DataSource = db.HakkimdaListele();
            Repeater1.DataBind();

            //Deneyimlerim Kısmını Listeleme
            DataSet1TableAdapters.Tbl_DeneyimTableAdapter db2 = new DataSet1TableAdapters.Tbl_DeneyimTableAdapter();
            Repeater2.DataSource = db2.DeneyimListesi();
            Repeater2.DataBind();

            //Eğitim Kismını Listeleme
            DataSet1TableAdapters.Tbl_EgitimTableAdapter db3 = new DataSet1TableAdapters.Tbl_EgitimTableAdapter();
            Repeater3.DataSource = db3.EgitimListesi();
            Repeater3.DataBind();

            //Hobi Kısmını Listeleme
            DataSet1TableAdapters.Tbl_HobilerTableAdapter db4 = new DataSet1TableAdapters.Tbl_HobilerTableAdapter();
            Repeater4.DataSource = db4.HobiListesi();
            Repeater4.DataBind();

            //Konferans Kısmını Listeleme
            DataSet1TableAdapters.Tbl_KonferanslarTableAdapter db5 = new DataSet1TableAdapters.Tbl_KonferanslarTableAdapter();
            Repeater5.DataSource = db5.KonferansListesi();
            Repeater5.DataBind();

            //Yetenek Kısmını Listeleme
            DataSet1TableAdapters.Tbl_YeteneklerTableAdapter db6 = new DataSet1TableAdapters.Tbl_YeteneklerTableAdapter();
            Repeater6.DataSource = db6.YetenekListesi();
            Repeater6.DataBind();

            // Resim Ekleme
            DataSet1TableAdapters.Tbl_HakkimdaTableAdapter dt7 = new DataSet1TableAdapters.Tbl_HakkimdaTableAdapter();
            Repeater7.DataSource = dt7.HakkimdaListele();
            Repeater7.DataBind();
        }
    }
}