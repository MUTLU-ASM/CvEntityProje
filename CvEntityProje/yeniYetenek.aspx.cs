﻿using CvEntityProje.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class yeniYetenek : System.Web.UI.Page
    {
        CvEntityDBEntities db = new CvEntityDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            yetenekler y = new yetenekler();
            y.yetenek = txtYetenek.Text;
            db.yetenekler.Add(y);
            db.SaveChanges();
            Response.Redirect("yeteneklerim.aspx");
        }
    }
}