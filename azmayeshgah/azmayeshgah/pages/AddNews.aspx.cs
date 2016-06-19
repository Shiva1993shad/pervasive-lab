using azmayeshgah.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace azmayeshgah.pages
{
    public partial class AddNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                BindGridView();
                txtNewsId.Text = String.Empty;
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
            var result = from n in db.newsfeeds
                         select new { n.news_id, n.title, n.news_day, n.link , n.descrip , n.active };

            GridView1.DataSource = result.ToList();
            GridView1.DataBind();
        }
        public void DeleteTxt()
        {
            txtNewsId.Text = String.Empty;
            txtSearch.Text = String.Empty;
            txtTitle.Text = String.Empty;
            txtLink.Text = String.Empty;
            txtDescrip.Text = String.Empty;
        }


        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
             var db = new perlabEntities();
            txtNewsId.Text = GridView1.SelectedRow.Cells[1].Text;
            txtTitle.Text = GridView1.SelectedRow.Cells[2].Text;
            txtLink.Text = GridView1.SelectedRow.Cells[3].Text;
            dropActive.SelectedItem.Text = GridView1.SelectedRow.Cells[4].Text;
            int newsID = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);
            var result = db.newsfeeds.FirstOrDefault(n => n.news_id == newsID);
            txtDescrip.Text = result.descrip;
          //  LResult.Text = result.title + "hi";
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string Username = HttpContext.Current.User.Identity.Name;
            perlabEntities db = new perlabEntities();
            var user = db.users.FirstOrDefault(p => p.username == Username);
            if (user != null) // Login
            {
                if (Convert.ToInt32(user.role) != 1) // Not admin
                {
                    Response.Redirect("~/Default.aspx");
                }
                else
                {
                   azmayeshgah.Models.newsfeed ne = new azmayeshgah.Models.newsfeed()
                    {
                        title = txtTitle.Text,
                        news_day = DateTime.Now,
                        descrip = txtDescrip.Text,
                        link=txtLink.Text,
                        active=(dropActive.SelectedItem.Text=="Yes")?true:false,


                    };
                    db.newsfeeds.Add(ne);
                    db.SaveChanges();
                    LResult.Text = "Successfully Saved";

                    BindGridView();
                    LResult.ForeColor = Color.Green;
                    DeleteTxt();
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

            newsfeed obj = new newsfeed();
            obj.news_id = int.Parse((txtNewsId.Text));
            var result = (from n in db.newsfeeds
                          where n.news_id == obj.news_id
                          select n).Single();

            result.title = txtTitle.Text;
            result.link = txtLink.Text;
            result.descrip = txtDescrip.Text;
            result.active = (dropActive.SelectedItem.Text)=="Yes"?true:false;
            result.descrip = txtDescrip.Text;
            db.newsfeeds.Add(result);
            db.SaveChanges();

            BindGridView();
            DeleteTxt();
        }


        protected void btnDelete_Click(object sender, EventArgs e)
        {
            perlabEntities db = new perlabEntities();

            newsfeed obj = new newsfeed();
            obj.news_id = int.Parse((txtNewsId.Text));
            var result = (from n in db.newsfeeds
                          where n.news_id == obj.news_id
                          select n).Single();

            db.newsfeeds.Remove(result);
            db.SaveChanges();

            BindGridView();
            DeleteTxt();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            perlabEntities db = new perlabEntities();

            newsfeed obj = new newsfeed();
            var key = (txtSearch.Text);
            var result = from ne in db.newsfeeds
                         where ne.title.Contains(key)
                         select new {ne.news_id, ne.title, ne.link,ne.active, ne.descrip };

            GridView1.DataSource = result.ToList();
            GridView1.DataBind();
            DeleteTxt();
        }
      
    }
}