using CvEntityProje.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace CvEntityProje
{
    public partial class login : System.Web.UI.Page
    {
        CvEntityDBEntities db = new CvEntityDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            var kullanici = txtKullanici.Text;
            var sifre = txtSifre.Text;

            var girisBilgisi = db.admin.Where(x => x.ad == kullanici && x.sifre == sifre).SingleOrDefault();
            if (girisBilgisi==null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (girisBilgisi != null)
            {
                Response.Redirect("istatistik.aspx");
            }

        }
    }
}