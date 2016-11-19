using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using candidatolimpo.Models;
using System.IO;
using System.Web.Script.Serialization;


namespace candidatolimpo.Controllers
{

    public class PerfilEleitorsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PerfilEleitors
        public ActionResult Index()
        {
            //carreega uma lista vazia no inicio
            List<PerfilEleitor> listaVazia = new List<PerfilEleitor>();



            return View(listaVazia);
        }




        [HttpPost]
        public ActionResult Index(string zona, string uf, string cidade)
        {


            uf = DropDownList.Uf.ListaUfs().Find(item => item.UfId == int.Parse(uf)).Nome;

            ConsultaWebservices consulta = new ConsultaWebservices();
            //CONSULTA WEBSERVICES BUSCA POR PREFEITOS DE ACORDO CO A SELEÇÃO PASSADA NO PARAMETRO
            List<PerfilEleitor> lstpfl = consulta.consultaEleitorado(zona, uf, cidade);






            return View(lstpfl);

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
