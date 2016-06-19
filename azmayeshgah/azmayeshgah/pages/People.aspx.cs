using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using azmayeshgah.Models;

namespace azmayeshgah.pages
{
    public partial class People : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          


        }
        public IQueryable<Models.person> Get_Academic_Staff(int? PeopleId)
        {
            
            var _db = new perlabEntities();
            
            {
                //string querystr = Request.QueryString["qusery"];
                var persons = _db.people.ToList();
                IQueryable<Models.person> query  = (from user in persons
                             where user.type.Equals("Academic Staff")
                             select new person
                             {
                                 name = user.name ,
                                 room = user.room ,
                                 link = user.link,
                                 email = user.email,
                                 picSrc = user.picSrc == null ? "../image/no-image-icon-md.png" : "../Content/Pic/" + user.picSrc,
                                 publications= user.publications, 
                             }).AsQueryable();
                //query = query.Where(p => p.name.Contains(querystr) && p.type == "Academic Staff");

                return query;
            }
        }
        public IQueryable<Models.person> Get_Past_Affiliates(int? PeopleId)
        {
            var _db = new perlabEntities();
            //if (Request.QueryString.AllKeys.Any(p => p == "query"))
            {
                //string querystr = Request.QueryString["qusery"];
                var persons = _db.people.ToList();
                IQueryable<Models.person> query = (from user in persons
                                                   where user.type.Equals("Past Affiliates")
                                                   select new person
                                                   {
                                                       name = user.name,
                                                       room = user.room,
                                                       link = user.link,
                                                       email = user.email,
                                                       picSrc = user.picSrc == null ? "../image/no-image-icon-md.png" : "../Content/Pic/" + user.picSrc,
                                                   }).AsQueryable();
                //query = query.Where(p => p.name.Contains(querystr) && p.type == "Academic Staff");

                return query;

            }
        }
        public IQueryable<Models.person> Get_PhD_students(int? PeopleId)
        {
            var _db = new perlabEntities();
            //if (Request.QueryString.AllKeys.Any(p => p == "query"))
            {
                //string querystr = Request.QueryString["qusery"];
                var persons = _db.people.ToList();
                IQueryable<Models.person> query = (from user in persons
                                                   where user.type.Equals("Ph.D. students")
                                                   select new person
                                                   {
                                                       name = user.name,
                                                       room = user.room,
                                                       link = user.link,
                                                       email = user.email,
                                                       picSrc = user.picSrc == null ? "../image/no-image-icon-md.png" : "../Content/Pic/" + user.picSrc,
                                                   }).AsQueryable();
                //query = query.Where(p => p.name.Contains(querystr) && p.type == "Academic Staff");

                return query;

            }
        }
        public IQueryable<Models.person> Get_MSc_students(int? PeopleId)
        {
            var _db = new perlabEntities();
            //if (Request.QueryString.AllKeys.Any(p => p == "query"))
            {
                //string querystr = Request.QueryString["qusery"];
                var persons = _db.people.ToList();
                IQueryable<Models.person> query = (from user in persons
                                                   where user.type.Equals("M.Sc. students")
                                                   select new person
                                                   {
                                                       name = user.name,
                                                       room = user.room,
                                                       link = user.link,
                                                       email = user.email,
                                                       picSrc = user.picSrc == null ? "../image/no-image-icon-md.png" : "../Content/Pic/" + user.picSrc,
                                                   }).AsQueryable();
                //query = query.Where(p => p.name.Contains(querystr) && p.type == "Academic Staff");

                return query;

            }
        }
        public IQueryable<Models.person> Get_BSc_students(int? PeopleId)
        {
            var _db = new perlabEntities();
            //if (Request.QueryString.AllKeys.Any(p => p == "query"))
            {
                //string querystr = Request.QueryString["qusery"];
                var persons = _db.people.ToList();
                IQueryable<Models.person> query = (from user in persons
                                                   where user.type.Equals("B.Sc. students")
                                                   select new person
                                                   {
                                                       name = user.name,
                                                       room = user.room,
                                                       link = user.link,
                                                       email = user.email,
                                                       picSrc = user.picSrc == null ? "../image/no-image-icon-md.png" : "../Content/Pic/" + user.picSrc,
                                                   }).AsQueryable();
                //query = query.Where(p => p.name.Contains(querystr) && p.type == "Academic Staff");

                return query;

            }
        }
        public IQueryable<Models.person> Get_Visitors(int? PeopleId)
        {
            var _db = new perlabEntities();
            //if (Request.QueryString.AllKeys.Any(p => p == "query"))
            {
                //string querystr = Request.QueryString["qusery"];
                var persons = _db.people.ToList();
                IQueryable<Models.person> query = (from user in persons
                                                   where user.type.Equals("Visitors")
                                                   select new person
                                                   {
                                                       name = user.name,
                                                       room = user.room,
                                                       link = user.link,
                                                       email = user.email,
                                                       picSrc = user.picSrc == null ? "../image/no-image-icon-md.png" : "../Content/Pic/" + user.picSrc,
                                                   }).AsQueryable();
                //query = query.Where(p => p.name.Contains(querystr) && p.type == "Academic Staff");

                return query;

            }
        }


        public IQueryable<Models.eventsfeed> Get_5event(int? eventID)
        {
            var _db = new perlabEntities();
            {
                var ev = _db.eventsfeeds.ToList();
                IQueryable<Models.eventsfeed> query = (from even in ev
                                                   select new eventsfeed
                                                   {
                                                       title = even.title,
                                                       call = even.call,
                                                       link = even.link,
                                                       deadline = even.deadline,
                                                       place=even.place,

                                                   }).Take(5).AsQueryable();

                return query;

            }
        }
        public IQueryable<Models.newsfeed> Get_news(int? newsID)
        {

            var _db = new perlabEntities();

            {
                //string querystr = Request.QueryString["qusery"];
                var newsfd = _db.newsfeeds.ToList();
                IQueryable<Models.newsfeed> query = (from n in newsfd
                                                     select new newsfeed
                                                     {
                                                         link = n.link,
                                                         title = n.title,
                                                         descrip = n.descrip,
                                                         news_day = n.news_day,
                                                     }).Take(5).AsQueryable();
                //query = query.Where(p => p.name.Contains(querystr) && p.type == "Academic Staff");

                return query;
            }
        }
    }
}