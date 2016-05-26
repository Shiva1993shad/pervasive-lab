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
    public partial class peopleAdd : System.Web.UI.Page
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
            var result = from p in db.people
                         select new { p.people_id, p.name,p.link, p.email,p.gradstatus,p.type,p.active, p.descrip,p.picSrc };

            GridView1.DataSource = result.ToList();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

 
            txtPeopleID.Text = GridView1.SelectedRow.Cells[1].Text;
            txtName.Text = GridView1.SelectedRow.Cells[2].Text;
            txtLink.Text = GridView1.SelectedRow.Cells[3].Text;
            txtEmail.Text = GridView1.SelectedRow.Cells[4].Text;
            dropGrad.SelectedItem.Text = GridView1.SelectedRow.Cells[5].Text;
            dropType.SelectedItem.Text = GridView1.SelectedRow.Cells[6].Text;
            dropActive.SelectedItem.Text = GridView1.SelectedRow.Cells[7].Text;
            txtDescrip.Text = GridView1.SelectedRow.Cells[8].Text;
        }

        protected void btnAdd_Click(object sender, EventArgs e)

        {
             string Username = HttpContext.Current.User.Identity.Name;
            perlabEntities db = new perlabEntities();
            var user = db.user1.FirstOrDefault(p => p.username == Username);
           // if (user != null) // Login
            //{
               // if (Convert.ToInt32(user.role )!=1) // Not admin
               // {
                   // Response.Redirect("~/Default.aspx");
               // }
              //  else if (!FUImage.HasFile)
              //  {
                    //default
                   
               // }
                if (!FUImage.FileName.EndsWith(".jpg") && !FUImage.FileName.EndsWith(".png"))
                {
                    LResult.Text = "wrong preview format";
                    LResult.ForeColor = Color.Red;
                }
                else
                {
                    string fileName = Path.GetFileName(FUImage.PostedFile.FileName);
                    FUImage.PostedFile.SaveAs(Server.MapPath(azmayeshgah.MyUtility.MyConfigs.PeopleImageDir) + fileName); // تبدیل آدرس نسبی به آدرس حقیقی و ذخیره عکس در آنجا
                    azmayeshgah.Models.person pe = new azmayeshgah.Models.person()
                    {
                        name= txtName.Text,
                        link = txtLink.Text,
                        email = txtEmail.Text,
                        gradstatus = dropGrad.SelectedItem.Text,
                        type = dropType.SelectedItem.Text,
                        active = dropActive.SelectedItem.Text,
                        descrip = txtDescrip.Text,
                        picSrc = fileName
                       
                    };
                    db.people.Add(pe);
                    db.SaveChanges();
                    LResult.Text = "Successfully Saved";

                    BindGridView();
                    LResult.ForeColor = Color.Green;

               }  
        
                        
          //   }      
          //  else
         //   {
          //      Response.Redirect("~/Default.aspx");
         //   }
        }
           
           

               /* obj.name= txtName.Text;
                if (FUImage.HasFile)
                {
                    int length = FUImage.PostedFile.ContentLength;
                    byte[] img = new byte[length];
                    FUImage.PostedFile.InputStream.Read(img, 0, length);
                    obj.pimage = img;

                }
                obj.link = txtLink.Text;
                obj.email = txtEmail.Text;
                obj.gradstatus = dropGrad.SelectedItem.Text;
                obj.type = dropType.SelectedItem.Text;
                obj.active = dropActive.SelectedItem.Text;
                obj.descrip = txtDescrip.Text;
                db.people.Add(obj);
                db.SaveChanges();
                lblMsg.Text = "Successfully Saved";

                BindGridView(); */
        

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            perlabEntities db = new perlabEntities();

            person obj = new person();
            obj.people_id = int.Parse((txtPeopleID.Text));
            var result = (from p in db.people
                          where p.people_id== obj.people_id
                          select p).Single();

            result.name = txtName.Text;
            result.link=txtLink.Text;
            result.email=txtEmail.Text;   
            result.gradstatus = dropGrad.SelectedItem.Text;
            result.type=dropType.SelectedItem.Text;
            result.active=dropActive.SelectedItem.Text;
            result.descrip = txtDescrip.Text;
            db.people.Add(result);
            db.SaveChanges();

            BindGridView();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            perlabEntities db = new perlabEntities();

            person obj = new person();
            obj.people_id = int.Parse((txtPeopleID.Text));
            var result = (from p in db.people
                          where p.people_id == obj.people_id
                          select p).Single();

            db.people.Remove(result);
            db.SaveChanges();

            BindGridView();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            perlabEntities db = new perlabEntities();

            person obj = new person();
            obj.people_id = int.Parse((txtSearch.Text));
            var result = from p in db.people
                         where p.people_id == obj.people_id
                         select new { p.people_id,p.name, p.email, p.descrip };

            GridView1.DataSource = result.ToList();
            GridView1.DataBind();
        }
      
    }
  }

    