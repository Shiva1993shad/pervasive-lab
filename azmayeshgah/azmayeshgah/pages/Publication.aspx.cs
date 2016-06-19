using azmayeshgah.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace azmayeshgah.pages
{
    public partial class Publication : System.Web.UI.Page
    {
        perlabEntities db = new perlabEntities();
        protected void Page_Load(object sender, EventArgs e)
        {


            int id = 0;

            if (Request.QueryString.AllKeys.Any(p => p == "id"))
            {
                string idstr = Request.QueryString["id"];
                int.TryParse(idstr, out id);
                //perlabEntities db = new perlabEntities();
                using (perlabEntities db = new perlabEntities())
                {
                    var query = from p in db.people
                                where p.people_id == id
                                select p.publications;
                    foreach (publication item in query)
                    {

                    }
                }
                string username = HttpContext.Current.User.Identity.Name; //
                //             var user = db.users.FirstOrDefault(p => p.username == username);
                // add.Enabled = user != null;
                //              var pro =db.publications.FirstOrDefault(p => p.p == id);
                //                 if (pro != null)

            }
        }
        public IQueryable<Models.newsfeed > Get_news(int? news_id)
        {

            var _db = new perlabEntities();
            
            
                //string querystr = Request.QueryString["qusery"];
                var newslist = _db.newsfeeds.ToList();
                IQueryable<Models.newsfeed> query = (from news in newslist
                                                   where news.news_id == news_id
                                                   orderby news.news_day 
                                                    select new newsfeed
                                                   {
                                                       title=news.title,
                                                       link = news.link,
                                                       descrip = news.descrip,
                                                   }).AsQueryable().Take(5);
            
            
        
            
            return query;
        }
        public IQueryable<Models.eventsfeed> Get_event(int? event_id)
        {

            var _db = new perlabEntities();


            //string querystr = Request.QueryString["qusery"];
            var eventlist = _db.eventsfeeds.ToList();
            IQueryable<Models.eventsfeed> query = (from ev in eventlist
                                                 where ev.event_id == event_id
                                               orderby ev.title
                                                 select new eventsfeed
                                                 {
                                                     title = ev.title,
                                                     link = ev.link,
                                                     descrip = ev.descrip,
                                                 }).AsQueryable().Take(5);


            return query;
        }

    }
}