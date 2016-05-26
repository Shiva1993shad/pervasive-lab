using azmayeshgah.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace azmayeshgah.pages
{
    public partial class AddDataset : System.Web.UI.Page
    {
                protected void Page_Load(object sender, EventArgs e)
        {

       
            if (!IsPostBack)
            {
                BindGridView();

            }

            string Username = HttpContext.Current.User.Identity.Name;
            perlabEntities db = new perlabEntities();
            var user = db.user1.FirstOrDefault(p => p.username == Username);
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
            var result = from e in db.datasets
                         select new { e.data_id,e.filename,e.description,e.attachment};

            GridView1.DataSource = result.ToList();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {


            txtDataId.Text = GridView1.SelectedRow.Cells[1].Text;
            txtFileName.Text = GridView1.SelectedRow.Cells[2].Text;
            txtDescrip.Text = GridView1.SelectedRow.Cells[3].Text;
           
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string Username = HttpContext.Current.User.Identity.Name;
            perlabEntities db = new perlabEntities();
            var user = db.user1.FirstOrDefault(p => p.username == Username);
             if (user != null) // Login
            {
             if (Convert.ToInt32(user.role )!=1) // Not admin
             {
             Response.Redirect("~/Default.aspx");
             }
             else
             {
                 azmayeshgah.Models.@event ev = new azmayeshgah.Models.@event()
                 {
                     title = txtTitle.Text,
                     link = txtLink.Text,
                     place = txtPlace.Text,
                     call = txtCall.Text,
                     deadline = txtDeadline.Text,
                     year=int.Parse(txtYear.Text),
                     active = (int.Parse(dropActive.SelectedItem.Text)==1)?true : false,
                     descrip = txtDescrip.Text,

                 };
                 db.events.Add(ev);
                 db.SaveChanges();
                 LResult.Text = "Successfully Saved";

                 BindGridView();
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

            @event obj = new @event();
            obj.event_id= int.Parse((txtEventId.Text));
            var result = (from p in db.events
                          where p.event_id == obj.event_id
                          select p).Single();

            result.call = txtCall.Text;
            result.link = txtLink.Text;
            result.deadline = txtDeadline.Text;
            result.active = (int.Parse(dropActive.SelectedItem.Text) == 1) ? true : false;
            result.descrip = txtDescrip.Text;
            db.events.Add(result);
            db.SaveChanges();

            BindGridView();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            perlabEntities db = new perlabEntities();

            @event  obj = new @event();
            obj.event_id = int.Parse((txtEventId.Text));
            var result = (from p in db.events
                          where p.event_id == obj.event_id
                          select p).Single();

            db.events.Remove(result);
            db.SaveChanges();

            BindGridView();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            perlabEntities db = new perlabEntities();

            @event obj = new @event();
            var key = (txtSearch.Text);
            var result = from ev in db.events
                         where ev.title.Contains(key)
                         select new { ev.title,ev.descrip,ev.call,ev.deadline };

            GridView1.DataSource = result.ToList();
            GridView1.DataBind();
        }
      
    }

    }
}