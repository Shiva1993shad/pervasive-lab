using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using azmayeshgah.Models;
using System.Web;
using System.Drawing;

namespace azmayeshgah.Account
{
    public partial class Manage : System.Web.UI.Page
    {
        //protected string SuccessMessage
        //{
        //    get;
        //    private set;
        //}

        //protected bool CanRemoveExternalLogins
        //{
        //    get;
        //    private set;
        //}

        //private bool HasPassword(UserManager manager)
        //{
        //    var user = manager.FindById(User.Identity.GetUserId());
        //    return (user != null && user.PasswordHash != null);
        //}

        protected void Page_Load()
        {
            if (!IsPostBack)
            {
                perlabEntities db = new perlabEntities();
                string usrname = HttpContext.Current.User.Identity.Name;
                var user = db.users.FirstOrDefault(p => p.username == usrname);

                if (user != null)
                {
                    if (user.role == 1)
                    {
                      //  Register_user.Visible = true;
                    }
                    UserName.Text = user.username;
                    Password.Text=user.password;
                    Email.Text = user.email;
                  
                }
                else
                {
                  //  Register_user.Visible = false;
                    Response.Redirect("~/Default.aspx");
                }
                 
            }
        }

        //protected void ChangePassword_Click(object sender, EventArgs e)
        //{
        //    if (IsValid)
        //    {
        //        //UserManager manager = new UserManager();
        //        //IdentityResult result = manager.ChangePassword(User.Identity.GetUserId(), CurrentPassword.Text, NewPassword.Text);
        //        //if (result.Succeeded)
        //        //{
        //        //    Response.Redirect("?m=ChangePwdSuccess");
        //        //}
        //        //else
        //        //{
        //        //    AddErrors(result);
        //        //}
        //    }
        //}

        //protected void SetPassword_Click(object sender, EventArgs e)
        //{
        //    if (IsValid)
        //    {
               
        //    }
        //}

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            perlabEntities db = new perlabEntities();
            string usrname = HttpContext.Current.User.Identity.Name;
            var user = db.users.FirstOrDefault(p => p.username == usrname);
            if (user != null)
            {
                user.email = Email.Text;
                if (db.users.Any(p => p.username == UserName.Text))
                {
                    LResult.Text = "this username already exist!";
                    //;
                    LResult.ForeColor = Color.Red;
                }
                else if (!db.users.Any(p => p.username == UserName.Text))
                {
                    user.username = UserName.Text;
                }
                if(Password.Text==Confirm_Password.Text)
                {
                    user.password = Password.Text;
                }
                
                db.SaveChanges();
                LResult.Text = "your information update successfully!";
                LResult.ForeColor = Color.Green;
            }
            else
            {
                LResult.Text = "کاربری یافت نشد";
                LResult.ForeColor = Color.Red;
            }
        }

    

   
    }
}