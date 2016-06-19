using azmayeshgah.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace azmayeshgah.pages
{
    public partial class News : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Models.newsfeed> Get_News(int? newsID)
        {

            var _db = new perlabEntities();

            {
                //string querystr = Request.QueryString["qusery"];
                var newsfd = _db.newsfeeds.ToList();
                IQueryable<Models.newsfeed> query = (from n in newsfd
                                                   select new newsfeed
                                                   {
                                                       link = n.link,
                                                       title=n.title,
                                                       descrip=n.descrip,
                                                       news_day=n.news_day,
                                                   }).AsQueryable();
                //query = query.Where(p => p.name.Contains(querystr) && p.type == "Academic Staff");

                return query;
            }
        }
      
    }
}