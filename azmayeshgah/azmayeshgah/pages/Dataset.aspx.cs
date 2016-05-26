using azmayeshgah.Models;
using System;
using System.Collections.Generic;
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
           
            string Username = HttpContext.Current.User.Identity.Name;
            perlabEntities db = new perlabEntities();
            var user = db.user1.FirstOrDefault(p => p.username == Username);
            Image underConstruct = new Image();
            underConstruct.ImageUrl= ("~/image/construction.png");
            underConstruct.Visible = true;
             DropDownList ShowOption=new DropDownList();
             ShowOption.Items.Add("show under construction image ");
             ShowOption.Items.Add("show dataset option");
             ShowOption.Visible=false;
             if (!IsPostBack)
             {
                 ShowOption.Visible = false;
                 underConstruct.Visible = true;
             }
            if(Convert.ToInt32(user.role) == 1)// role is  admin
            {
                underConstruct.Visible= false;
                ShowOption.Visible=true;
               
            }
           if (ShowOption.SelectedItem.Text == "show dataset option")
                {
                    if (user == null)// not logged in
                    {
                        
                        Response.Redirect("~/Default.aspx");
                        
                    }
                    if (Convert.ToInt32(user.role) == 0 || Convert.ToInt32(user.role) == 1)//  logged in as user or admin
                    {

                       //بتونه دیتاست ببینه و دانلود کنه

                    }

                }
           else if (ShowOption.SelectedItem.Text == "show under construction image")
           {
               underConstruct.Visible = true;
           }



          

        }

    }
}