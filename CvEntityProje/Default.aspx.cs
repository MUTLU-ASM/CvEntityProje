using CvEntityProje.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Default : System.Web.UI.Page
    {
        CvEntityDBEntities db = new CvEntityDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            rptBilgiler.DataSource = db.hakkinda.ToList();
            rptBilgiler.DataBind();

            rptEgitim.DataSource = db.hakkinda.ToList();
            rptEgitim.DataBind();

            rptDeneyim.DataSource = db.hakkinda.ToList();
            rptDeneyim.DataBind();

            rptYetenek.DataSource = db.yetenekler.ToList();
            rptYetenek.DataBind();
        }
    }
}