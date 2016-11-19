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
    public class VereadorsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Vereadors
        public ActionResult Index()
        {



            List<Vereador> listaVazia = new List<Vereador>();


            return View(listaVazia);
        }

        [HttpPost]
        public ActionResult Index(string uf, string cidade, string escolaridade, string sexo, string partido)
        {
            uf = DropDownList.Uf.ListaUfs().Find(item => item.UfId == int.Parse(uf)).Nome;
            ConsultaWebservices consulta = new ConsultaWebservices();
            List<Vereador> lstv = new List<Vereador>();

            if (uf==""||cidade=="")
            {
                //erro nao buscar
            }


            else if(partido != "" && sexo != "" && escolaridade != "")
            {
                //busca por combinacao
                //CONSULTA WEBSERVICES BUSCA POR Vereador DE ACORDO CO A SELEÇÃO PASSADA NO PARAMETRO
                lstv = consulta.consultaVereadorCombinacao(uf, cidade, escolaridade, sexo, partido);
            }

            else if(escolaridade!="" )
            {
                //busca por escolaridade
                //CONSULTA WEBSERVICES BUSCA POR Vereador DE ACORDO CO A SELEÇÃO PASSADA NO PARAMETRO
                lstv = consulta.consultaVereadorEscolaridade(uf, cidade, escolaridade);
            }
            else if(sexo != "")
            {
                //busca por sexo
                //CONSULTA WEBSERVICES BUSCA POR Vereador DE ACORDO CO A SELEÇÃO PASSADA NO PARAMETRO
                lstv = consulta.consultaVereadorSexo(uf, cidade, sexo);
            }

            else if(partido != "")
            {
                //busca por partido
                //CONSULTA WEBSERVICES BUSCA POR Vereador DE ACORDO CO A SELEÇÃO PASSADA NO PARAMETRO
                lstv = consulta.consultaVereadorPartido(uf, cidade, partido);
            }
            else 
            {
                //busca por cidade
                //CONSULTA WEBSERVICES BUSCA POR Vereador DE ACORDO CO A SELEÇÃO PASSADA NO PARAMETRO
                lstv = consulta.consultaVereadorCidade(uf, cidade);
            }
            


            return View(lstv);
        }

        // GET: Vereadors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vereador vereador = db.Vereadors.Find(id);
            if (vereador == null)
            {
                return HttpNotFound();
            }
            return View(vereador);
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
