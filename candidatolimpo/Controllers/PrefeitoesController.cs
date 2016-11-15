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
            ConsultaWebservices consulta = new ConsultaWebservices();

            //CONSULTA WEBSERVICES BUSCA POR PREFEITOS DE ACORDO CO A SELEÇÃO PASSADA NO PARAMETRO
            List<Prefeito> listaVazia = new List<Prefeito>();//consulta.consultaPrefeito("AC", "CRUZEIRO DO SUL");


            return View(listaVazia);
        }

        [HttpPost]
        public ActionResult Index(string uf, string cidade)
        {
            ConsultaWebservices consulta = new ConsultaWebservices();
            //CONSULTA WEBSERVICES BUSCA POR PREFEITOS DE ACORDO CO A SELEÇÃO PASSADA NO PARAMETRO
            List<Prefeito> lstpf = consulta.consultaPrefeito(uf, cidade);






            return View(lstpf);
        }

        // GET: Prefeitoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prefeito prefeito = db.Prefeitoes.Find(id);
            if (prefeito == null)
            {
                return HttpNotFound();
            }
            return View(prefeito);
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
