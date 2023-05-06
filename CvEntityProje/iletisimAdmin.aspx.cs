using CvEntityProje.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class iletisimAdmin : System.Web.UI.Page
    {
        CvEntityDBEntities db = new CvEntityDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var ilet = db.iletisim.ToList();
            rptId.DataSource = ilet;
            rptId.DataBind();
        }
    }
}