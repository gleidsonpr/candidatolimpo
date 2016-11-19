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
    public class PrefeitoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Prefeitoes
        public ActionResult Index()
        {




            List<Prefeito> listaVazia = new List<Prefeito>();


            return View(listaVazia);
        }

        [HttpPost]
        public ActionResult Index(string uf, string cidade)
        {           

            
             uf = DropDownList.Uf.ListaUfs().Find(item => item.UfId == int.Parse(uf)).Nome;

            ConsultaWebservices consulta = new ConsultaWebservices();
            //CONSULTA WEBSERVICES BUSCA POR PREFEITOS DE ACORDO CO A SELEÇÃO PASSADA NO PARAMETRO
            List<Prefeito> lstpf = consulta.consultaPrefeito(uf, cidade);






            return View(lstpf);
        }

        // GET: Prefeitoes/Details/5
        public ActionResult Details(int? id)
        {

            List<Prefeito> listaVazia = new List<Prefeito>();


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
