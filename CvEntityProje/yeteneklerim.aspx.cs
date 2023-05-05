using CvEntityProje.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class hakkimda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CvEntityDBEntities db = new CvEntityDBEntities();
            rptId.DataSource = db.yetenekler.ToList();
            rptId.DataBind();
        }
    }
}