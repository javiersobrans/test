using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTest.Models;

namespace MvcTest.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lista()
        {

            List<Cliente> lista = new List<Cliente>();

            using (var db = new LiteDatabase(System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/OneData.db")))
            {

                var clientes = db.GetCollection<Cliente>("clientes");
                var results = clientes.FindAll();
                foreach (Cliente cli in results)
                {
                    lista.Add(cli);
                }
            }

            return View(lista);
        }


    }
}