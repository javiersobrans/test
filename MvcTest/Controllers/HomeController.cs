using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTest.Models;
using PagedList;

namespace MvcTest.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lista(int? page)
        {

            List<Cliente> lista = new List<Cliente>();

            using (var db = new LiteDatabase(System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/OneData.db")))
            {
                var clientes = db.GetCollection<Cliente>("clientes");
                lista = clientes.FindAll().ToList();
            }

            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(lista.ToPagedList(pageNumber, pageSize));

        }



    }
}