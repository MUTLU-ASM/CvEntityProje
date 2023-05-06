using CvEntityProje.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class yetenekSil : System.Web.UI.Page
    {
        CvEntityDBEntities db = new CvEntityDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["id"]);
            var ytnk = db.yetenekler.Find(x);
            db.yetenekler.Remove(ytnk);
            db.SaveChanges();
            Response.Redirect("yeteneklerim.aspx");
        }
    }
}