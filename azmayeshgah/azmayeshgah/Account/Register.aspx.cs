using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using azmayeshgah.Models;
using System.Web.Security;
using System.Web.UI.WebControls;
using azmayeshgah.MyUtility;
using Microsoft.Owin.Security;

namespace azmayeshgah.Account
{
    public partial class Register : Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {
           /* var manager = new UserManager();
            var user = new ApplicationUser() { UserName = UserName.Text };
            IdentityResult result = manager.Create(user, Password.Text);
            if (result.Succeeded)
            {
                IdentityHelper.SignIn(manager, user, isPersistent: false);
                IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            }
            else 
            {
                ErrorMessage.Text = result.Errors.FirstOrDefault();
            }*/
            perlabEntities db = new perlabEntities();
            if (string.IsNullOrEmpty(UserName.Text)
                || string.IsNullOrEmpty(Password.Text)
                || string.IsNullOrEmpty(ConfirmPassword.Text)
                || string.IsNullOrEmpty(Role.SelectedValue)
                || string.IsNullOrEmpty(Email.Text)
                )
            {
                LResult.Text ="Please fill out all the required fields";
                //"لطفا فرم را به طور کامل تکمیل نمایید";
                
            }
           
            else
            {
                db.user1.Add(new user1()
                {
                    
                    email = Email.Text,
                    role=0,
                    password = Password.Text,
                    username = UserName.Text
                });
                db.SaveChanges();
                LResult.Text = "User added successfully ";
                Response.Redirect("~/Account/Login");
                //"نام کاربری شما با موفقیت اضافه شد . هم اکنون می توانید به سیستم وارد شوید";
                // Resources.Resource.UrUsernameAddSuccessfully
              
            }
        }
    }
}