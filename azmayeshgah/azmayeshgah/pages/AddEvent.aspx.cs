using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Web.UI;
using System.Web.UI.WebControls;
using azmayeshgah.Models;
using azmayeshgah.MyUtility;

namespace azmayeshgah.pages
{
    public partial class AddEvent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                BindGridView();
                txtPlace.Text = String.Empty;
                txtDeadline.Text = String.Empty;
                txtCall.Text = String.Empty;
                txtYear.Text = String.Empty;
                txtSearch.Text = String.Empty;
                txtTitle.Text = String.Empty;
                txtLink.Text = String.Empty;
                txtDescrip.Text = String.Empty;

            }

            string Username = HttpContext.Current.User.Identity.Name;
            perlabEntities db = new perlabEntities();
            var user = db.users.FirstOrDefault(p => p.username == Username);
            if (user != null) // Not Login
            {
                if (Convert.ToInt32(user.role) != 1) // Not admin
                {
                    Response.Redirect("~/Default.aspx");
                }
            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }
        }


        public void BindGridView()
        {
            var db = new perlabEntities();
            var result = from e in db.eventsfeeds
                         select new { e.event_id,e.title,e.link,e.place,e.deadline,e.call,e.year,e.descrip,e.active};

            GridView1.DataSource = result.ToList();
            GridView1.DataBind();
        }
        /// <summary>
        /// ///////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DeleteTxt()
        {
            txtPlace.Text = String.Empty;
            txtDeadline.Text = String.Empty;
            txtCall.Text = String.Empty;
            txtYear.Text = String.Empty;
            txtSearch.Text = String.Empty;
            txtTitle.Text = String.Empty;
            txtLink.Text = String.Empty;
            txtDescrip.Text = String.Empty;
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {


            txtEventId.Text = GridView1.SelectedRow.Cells[1].Text;
            txtTitle.Text = GridView1.SelectedRow.Cells[2].Text;
            txtDescrip.Text = GridView1.SelectedRow.Cells[3].Text;
            txtLink.Text = GridView1.SelectedRow.Cells[4].Text;
            txtPlace.Text= GridView1.SelectedRow.Cells[5].Text;
            txtCall.Text= GridView1.SelectedRow.Cells[6].Text;
            txtDeadline.Text= GridView1.SelectedRow.Cells[7].Text;
            txtYear.Text= GridView1.SelectedRow.Cells[8].Text;
            dropActive.SelectedItem.Text = GridView1.SelectedRow.Cells[9].Text;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string Username = HttpContext.Current.User.Identity.Name;
            perlabEntities db = new perlabEntities();
            var user = db.users.FirstOrDefault(p => p.username == Username);
             if (user != null) // Login
            {
             if (Convert.ToInt32(user.role )!=1) // Not admin
             {
             Response.Redirect("~/Default.aspx");
             }
             else
             {
                 azmayeshgah.Models.eventsfeed ev = new azmayeshgah.Models.eventsfeed()
                 {
                     title = txtTitle.Text,
                     link = txtLink.Text,
                     place = txtPlace.Text,
                     call = txtCall.Text,
                     deadline = txtDeadline.Text,
                     year=int.Parse(txtYear.Text),
                     active = (dropActive.SelectedItem.Text=="Yes")?true : false,
                     descrip = txtDescrip.Text,

                 };
                 db.eventsfeeds.Add(ev);
                 db.SaveChanges();
                 LResult.Text = "Successfully Saved";

                 BindGridView();
                 DeleteTxt();
                 LResult.ForeColor = Color.Green;
             }
               

            }
     
              else
               {
                  Response.Redirect("~/Default.aspx");
               }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            perlabEntities db = new perlabEntities();

            eventsfeed obj = new eventsfeed();
            obj.event_id= int.Parse((txtEventId.Text));
            var result = (from p in db.eventsfeeds
                          where p.event_id == obj.event_id
                          select p).Single();

            result.call = txtCall.Text;
            result.link = txtLink.Text;
            result.deadline = txtDeadline.Text;
            result.active = (int.Parse(dropActive.SelectedItem.Text) == 1) ? true : false;
            result.descrip = txtDescrip.Text;
            db.eventsfeeds.Add(result);
            db.SaveChanges();

            BindGridView();
            DeleteTxt();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            perlabEntities db = new perlabEntities();

            eventsfeed  obj = new eventsfeed();
            obj.event_id = int.Parse((txtEventId.Text));
            var result = (from p in db.eventsfeeds
                          where p.event_id == obj.event_id
                          select p).Single();

            db.eventsfeeds.Remove(result);
            db.SaveChanges();

            BindGridView();
            DeleteTxt();

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            perlabEntities db = new perlabEntities();

            eventsfeed obj = new eventsfeed();
            var key = (txtSearch.Text);
            var result = from ev in db.eventsfeeds
                         where ev.descrip.Contains(key)
                         select new { ev.title,ev.descrip,ev.call,ev.deadline };

            GridView1.DataSource = result.ToList();
            GridView1.DataBind();
            DeleteTxt();
        }
      
    }
}