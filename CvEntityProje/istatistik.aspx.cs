using CvEntityProje.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class istatistik : System.Web.UI.Page
    {
        CvEntityDBEntities db = new CvEntityDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTplmYtnk.Text = db.yetenekler.Count().ToString();
            lblTplmMesaj.Text = db.iletisim.Count().ToString();
            lblDrcOrtlm.Text = db.yetenekler.Average(x => x.derece).ToString();
            lblEnYksDrc.Text = db.yetenekler.Max(x => x.yetenek).ToString();
        }
    }
}