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
    public class UsuariosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Usuarios
        public ActionResult Index()
        {
            ConsultaWebservices consulta = new ConsultaWebservices();

            //CONSULTA WEBSERVICES BUSCA POR usuarios DE ACORDO CO A Ssenha e cpf
            List<Usuario> listaVazia = new List<Usuario>();


            return View(listaVazia);
        }

        [HttpPost]
        public ActionResult Index(string cpf, string senha)
        {
            ConsultaWebservices consulta = new ConsultaWebservices();
            //CONSULTA WEBSERVICES BUSCA POR usuarios DE ACORDO CO A Ssenha e cpf

            List<Usuario> lstpf = new List<Usuario>();
            if (cpf != "" && senha != "")
            {
                 lstpf = consulta.usuarioLogin(cpf, senha);
            }


            if(lstpf.Count>0)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Login falhou, verifique CPF e SENHA')</script>");
            }




            return View(lstpf);
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
