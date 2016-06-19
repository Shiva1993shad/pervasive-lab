using azmayeshgah.Models;
using azmayeshgah.MyUtility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
            var user = db.users.FirstOrDefault(p => p.username == Username);
            if (user != null) //  Login
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
                         select new { e.data_id,e.filename,e.description,e.filepath};

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
            var user = db.users.FirstOrDefault(p => p.username == Username);
             if (user != null) // Login
            {
             if (Convert.ToInt32(user.role )!=1) // Not admin
             {
             Response.Redirect("~/Default.aspx");
             }
             else
             {
                   string  filePath = Path.GetFileName(FUIDataset.PostedFile.FileName);
                   FUIDataset.PostedFile.SaveAs(Server.MapPath(azmayeshgah.MyUtility.MyConfigs.DatasetDir) + filePath); // تبدیل آدرس نسبی به آدرس حقیقی و ذخیره فایل در آنجا
                    azmayeshgah.Models.dataset da = new azmayeshgah.Models.dataset()
                    {
                        filepath = filePath,
                        filename=txtFileName.Text,
                        description=txtDescrip.Text,

                       
                    };
                    db.datasets.Add(da);
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


        protected void btnDelete_Click(object sender, EventArgs e)
        {
            perlabEntities db = new perlabEntities();

            dataset obj = new dataset();
            obj.data_id = int.Parse((txtDataId.Text));
            var result = (from p in db.datasets
                          where p.data_id == obj.data_id
                          select p).Single();

            db.datasets.Remove(result);
            db.SaveChanges();

            BindGridView();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            perlabEntities db = new perlabEntities();

            dataset obj = new dataset();
            var key = (txtSearch.Text);
            var result = from da in db.datasets
                         where da.description.Contains(key)
                         select new {da.filename,da.description};

            GridView1.DataSource = result.ToList();
            GridView1.DataBind();
        }
      
    }

   
}