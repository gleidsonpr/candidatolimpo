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
        ConsultaWebservices consulta = new ConsultaWebservices();
        //CONSULTA WEBSERVICES BUSCA POR usuarios DE ACORDO CO A Ssenha e cpf
        List<Usuario> listaVazia = new List<Usuario>();
        // GET: Usuarios
        public ActionResult Index()
        {

            return View(listaVazia);
        }

        [HttpPost]
        public ActionResult Index(string cpf, string senha)
        {
            

            if (cpf != "" && senha != "")
            {
                if(login(cpf, senha))
                {
                    return RedirectToAction("Index", "Dashboards");
                }
                else
                {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Login falhou, verifique CPF e SENHA')</script>");
                }

            }
            else
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('CPF e/ou SENHA não informado')</script>");
            }



            return View(listaVazia);
        }

        public bool login(string cpf, string senha)
        {
                       

            List<Usuario> lstpf = new List<Usuario>();
            lstpf = consulta.usuarioLogin(cpf, senha);
            if (lstpf.Count > 0)
            {
                Session["usuarioLogado"] = lstpf[0].Nome;
                return true;
            }
            else
            {
                return false;
            }


        }
        public ActionResult Logout()
        {
            Session.Remove("usuarioLogado");
            return RedirectToAction("Index", "Home");
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
