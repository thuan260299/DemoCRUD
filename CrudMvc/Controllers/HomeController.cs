using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudMvc.Models;

namespace CrudMvc.Controllers
{
    public class HomeController : Controller
    {
        
//        public ActionResult PagingSortingAndSearching(string sortOn, string orderBy,
//string pSortOn, string keyword, int? page)
//        {
//            using (CRUBEntities db=new CRUBEntities())
            
//            if (!page.HasValue)
//            {
//                page = 1; // set initial page value
//                if (string.IsNullOrWhiteSpace(orderBy) || orderBy.Equals("asc"))
//                {
//                    orderBy = "desc";
//                }
//                else
//                {
//                    orderBy = "asc";
//                }
//            }

//            // override the sort order if the previous sort order and current request sort order is different
//            if (!string.IsNullOrWhiteSpace(sortOn) && !sortOn.Equals(pSortOn,StringComparison.CurrentCultureIgnoreCase))
//            {
//                orderBy = "asc";
//            }

//            ViewBag.OrderBy = orderBy;
//            ViewBag.SortOn = sortOn;
//            ViewBag.Keyword = keyword;

//            var list = db.PersonalDetails.AsQueryable();

//            switch (sortOn)
//            {
//                case "FirstName":
//                    if (orderBy.Equals("desc"))
//                    {
//                        list = list.OrderByDescending(p => p.FirstName);
//                    }
//                    else
//                    {
//                        list = list.OrderBy(p => p.FirstName);
//                    }
//                    break;
//                case "LastName":
//                    if (orderBy.Equals("desc"))
//                    {
//                        list = list.OrderByDescending(p => p.LastName);
//                    }
//                    else
//                    {
//                        list = list.OrderBy(p => p.LastName);
//                    }
//                    break;
//                case "Age":
//                    if (orderBy.Equals("desc"))
//                    {
//                        list = list.OrderByDescending(p => p.Age);
//                    }
//                    else
//                    {
//                        list = list.OrderBy(p => p.Age);
//                    }
//                    break;
//                default:
//                    list = list.OrderBy(p => p.AutoId);
//                    break;
//            }
//            if (!string.IsNullOrWhiteSpace(keyword))
//            {
//                list = list.Where(f => f.FirstName.StartsWith(keyword));
//            }
          
//            return View(finalList);
//        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}