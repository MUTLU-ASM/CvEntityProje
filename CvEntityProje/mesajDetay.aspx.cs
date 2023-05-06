using CvEntityProje.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class mesajDetay : System.Web.UI.Page
    {
        CvEntityDBEntities db = new CvEntityDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            var mesaj = db.iletisim.Find(id);
            txtAdSoyad.Text = mesaj.adsoyad;
            txtMail.Text = mesaj.mail;
            txtKonu.Text = mesaj.konu;
            txtMesaj.Text = mesaj.mesaj;
        }
    }
}