using CvEntityProje.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class yetenekGuncelle : System.Web.UI.Page
    {
        CvEntityDBEntities db = new CvEntityDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            if (Page.IsPostBack == false)
            {
            var ytnk = db.yetenekler.Find(id);
            txtGuncelle.Text = ytnk.yetenek;
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            var ytnk = db.yetenekler.Find(id);
            ytnk.yetenek = txtGuncelle.Text;
            db.SaveChanges();
            Response.Redirect("yeteneklerim.aspx");
        }
    }
}