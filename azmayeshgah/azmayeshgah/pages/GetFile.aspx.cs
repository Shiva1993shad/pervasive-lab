using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using azmayeshgah.MyUtility;
using azmayeshgah.Models;
using System.IO;


namespace azmayeshgah.pages
{
  
    public partial class GetFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int data_id = Convert.ToInt16(Request.QueryString["data_id"]);
           // if (id == 0) { return null; }
            perlabEntities db = new perlabEntities();
          
               string filePath = (from p in db.datasets
                          where p.data_id == data_id
                          select p.filepath).Single();
               

            // string relativePath =  "../Content/Pic/" + result;
            //Response.AppendHeader("content-disposition", "attachment; filename=" + fileName); //this will open in a new tab.. remove if you want to open in the same tab.
            //Response.WriteFile(relativePath);
            //string filePath = (sender as LinkButton).CommandArgument;
            Response.ContentType = ContentType;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(Server.MapPath(filePath)));
           // Response.WriteFile(filePath);
          //   Response.TransmitFile(Server.MapPath("pages/" + filePath));
          //  Response.End();
          //  Response.TransmitFile(filePath);
            Response.Flush();

        }        
    }
}