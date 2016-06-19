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
using System.Drawing;

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
                LResult.Text = "Please fill out all the required fields";
                //"لطفا فرم را به طور کامل تکمیل نمایید";

                //"لطفا فرم را به طور کامل تکمیل نمایید";
                LResult.ForeColor = Color.Red;
            }
            else if (Password.Text.Length < 5)
            {
                LResult.Text = "طول پسورد حداقل باید 5 کاراکتر باشد";
                //
                LResult.ForeColor = Color.Red;
            }
            else if (Password.Text != ConfirmPassword.Text)
            {
                LResult.Text = "رمز عبور با تکرار آن یکسان نیست";
                //
                LResult.ForeColor = Color.Red;
            }
            else if (!Email.Text.Contains("@") || !Email.Text.Contains("."))
            {
                LResult.Text = "لطفا رایانامه معتبر وارد نمایید";
                //
                LResult.ForeColor = Color.Red;
            }
            else if (db.users.Any(p => p.username == UserName.Text))
            {
                LResult.Text = "این نام کاربری قبلا در سیستم ثبت شده است";
                //;
                LResult.ForeColor = Color.Red;
            }
            else if (db.users.Any(p => p.email == Email.Text))
            {
                LResult.Text = "این رایانامه قبلا در سیستم ثبت شده است";
                //
                LResult.ForeColor = Color.Red;

            }
            else
            {
                db.users.Add(new user()
                {
                    email = Email.Text,
                    role = (Role.SelectedItem.Text =="Admin") ? 1 : 0,
                    password = Password.Text,
                    username = UserName.Text
                });
                db.SaveChanges();
                LResult.ForeColor = Color.Green;
                LResult.Text = "User added successfully ";
                Response.Redirect("~/Account/Login");

            }



        }
    }
}