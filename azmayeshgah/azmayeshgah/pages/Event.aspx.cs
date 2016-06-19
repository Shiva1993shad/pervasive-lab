using azmayeshgah.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace azmayeshgah.pages
{
    public partial class Event : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //    public IQueryable<Models.eventsfeed> Get_event(int? eventID)
        //    {

        //        var _db = new perlabEntities();


        //        //string querystr = Request.QueryString["qusery"];
        //        var eventlist = _db.eventsfeeds.ToList();
        //        IQueryable<Models.eventsfeed> query = (from ev in eventlist
        //                                           orderby ev.year
        //                                           select new eventsfeed
        //                                           {
        //                                               title = ev.title,
        //                                               link = ev.link,
        //                                               descrip = ev.descrip,
        //                                               call=ev.call,
        //                                               place=ev.place,
        //                                               deadline=ev.deadline,
        //                                           }).AsQueryable();


        //        return query;
        //    }

        //}
        public IQueryable<Models.eventsfeed> Get_event(int? eventID)
        {

            var _db = new perlabEntities();

            {
                //string querystr = Request.QueryString["qusery"];
                var evenfeed = _db.eventsfeeds.ToList();
                IQueryable<Models.eventsfeed> query = (from e in evenfeed
                                                       orderby e.year
                                                       select new eventsfeed
                                                       {
                                                           link = e.link,
                                                           title = e.title,
                                                           descrip = e.descrip,
                                                           call = e.call,
                                                           deadline = e.deadline,
                                                           place = e.place,
                                                           year = e.year,
                                                       }).AsQueryable();
                //query = query.Where(p => p.name.Contains(querystr) && p.type == "Academic Staff");

                return query;
            }
        }
    }
}