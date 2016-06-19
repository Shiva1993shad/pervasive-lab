using azmayeshgah.Models;
using azmayeshgah.MyUtility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace azmayeshgah.pages
{
    public partial class Dataset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //DropDownList ShowOption = new DropDownList();
            //ShowOption.Visible = true;
            UnderConstruct.Visible = false;
            datagrid.Visible = false;
            string Username = HttpContext.Current.User.Identity.Name;
            perlabEntities db = new perlabEntities();
            var user = db.users.FirstOrDefault(p => p.username == Username);
            if (user != null)
            {
                BindGridView();
                datagrid.Visible = true;
               
            }
            else
            {
                UnderConstruct.Visible = true;
            
                
            }
             
             //ShowOption.Items.Add("show under construction image ");
             //ShowOption.Items.Add("show dataset option");
            
          
        
           //if (ShowOption.SelectedItem.Text == "show dataset option")
           //     {
           //         if (user == null)// not logged in
           //         {
                        
           //             Response.Redirect("~/Default.aspx");
                        
           //         }
           //         if (Convert.ToInt32(user.role) == 0 || Convert.ToInt32(user.role) == 1)//  logged in as user or admin
           //         {
           //             datagrid.Visible = true;

           //            //بتونه دیتاست ببینه و دانلود کنه

           //         }

           //     }
           //else if (ShowOption.SelectedItem.Text == "show under construction image")
           //{
           //    underConstruct.Visible = true;
           //}
  

        }
        public void BindGridView()
        {
            var db = new perlabEntities();
            var result = from e in db.datasets
                         select new { e.data_id, e.filename, e.description, e.filepath };

            datagrid.DataSource = result.ToList();
            datagrid.DataBind();
        }

        protected void datagrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //public File ViewResume(int id)
        //{
        //    if (id == 0) { return null; }
        //    Resume resume = new Resume();
        //    ResumeContext rc = new ResumeContext();
        //    resume = rc.Resume.Where(a => a.ResumeID == id).SingleOrDefault();
        //    Response.AppendHeader("content-disposition", "inline; filename=file.pdf"); //this will open in a new tab.. remove if you want to open in the same tab.
        //    return File(resume.Resume, "application/pdf");
        //}

    }
}