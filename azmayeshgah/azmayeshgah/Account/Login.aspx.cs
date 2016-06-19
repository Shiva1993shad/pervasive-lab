using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using azmayeshgah.Models;
using System.Web.UI.WebControls;

namespace azmayeshgah.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Username = HttpContext.Current.User.Identity.Name;
            perlabEntities db = new perlabEntities();
            var user = db.users.FirstOrDefault(p => p.username == Username);
            if(user != null)
            {
                if (user.role == 1) //  admin
                {
                    RegisterHyperLink.Visible = true;
                }
                else
                {
                    RegisterHyperLink.Visible = false;
                }
            }
           
            else
            {
                RegisterHyperLink.Visible = false;
            }
            
            RegisterHyperLink.NavigateUrl = "Register";
            OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
            
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            perlabEntities db = new perlabEntities();
            if (db.users.Any(p => p.username== UserName.Text && p.password == Password.Text))
            {
                
                FormsAuthentication.SetAuthCookie(UserName.Text, true);
                Result.Text = "successfull log In";
                
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                Result.Text = "Wrong username or password";
            }
        }
    }
}