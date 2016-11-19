using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using candidatolimpo.Models;

namespace candidatolimpo.Controllers
{
    public class DashboardsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Dashboards
        public ActionResult Index()
        {


            if (Session["usuarioLogado"] == null)
            {
               
                return RedirectToAction("Index", "Usuarios");
            }
           



            List<Dashboard> listaVazia = new List<Dashboard>();


            return View(listaVazia);
        }       

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
