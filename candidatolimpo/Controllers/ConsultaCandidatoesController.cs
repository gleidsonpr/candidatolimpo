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
    public class ConsultaCandidatoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ConsultaCandidatoes
        public ActionResult Index()
        {
            List<ConsultaCandidato> csc = new List<ConsultaCandidato>();
            return View(csc);
        }

        // GET: ConsultaCandidatoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConsultaCandidato consultaCandidato = db.ConsultaCandidatoes.Find(id);
            if (consultaCandidato == null)
            {
                return HttpNotFound();
            }
            return View(consultaCandidato);
        }

        // GET: ConsultaCandidatoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConsultaCandidatoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Data_geracao,Hora_geracao,Ano_eleicao,Num_turno,Descricao_eleicao,Sigla_uf,Siglas_ue,Descricao_ue,Codigo_cargo,Descricao_cargo,Nome_canditado,Sequencial_canditado,Numero_candidato,Cpf_candidato,Nome_urna_candidato,Cod_situacao_candidatura,Des_situacao_candidatura,Numero_partido,Sigla_partido,Nome_partido,Codigo_legenda,Sigla_legenda,Composicao_legenda,Nome_legenda,Codigo_ocupacao,Descricao_ocupacao,Data_nascimento,Num_titulo_eleitoral_candidato,Idade_data_eleicao,Codigo_sexo,Descricao_sexo,Cod_grau_instrucao,Descricao_grau_instrucao,Codigo_estado_civil,Descricao_estado_civil,Codigo_cor_raca,Descricao_cor_raca,Codigo_nacionalidade,Descricao_nacionalidade,Sigla_uf_nascimento,Codigo_municipio_nascimento,Nome_municipio_nascimento,Despesa_max_campanha,Cod_sit_tot_turno,Desc_sit_tot_turno,Nm_email")] ConsultaCandidato consultaCandidato)
        {
            if (ModelState.IsValid)
            {
                db.ConsultaCandidatoes.Add(consultaCandidato);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(consultaCandidato);
        }

        // GET: ConsultaCandidatoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConsultaCandidato consultaCandidato = db.ConsultaCandidatoes.Find(id);
            if (consultaCandidato == null)
            {
                return HttpNotFound();
            }
            return View(consultaCandidato);
        }

        // POST: ConsultaCandidatoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Data_geracao,Hora_geracao,Ano_eleicao,Num_turno,Descricao_eleicao,Sigla_uf,Siglas_ue,Descricao_ue,Codigo_cargo,Descricao_cargo,Nome_canditado,Sequencial_canditado,Numero_candidato,Cpf_candidato,Nome_urna_candidato,Cod_situacao_candidatura,Des_situacao_candidatura,Numero_partido,Sigla_partido,Nome_partido,Codigo_legenda,Sigla_legenda,Composicao_legenda,Nome_legenda,Codigo_ocupacao,Descricao_ocupacao,Data_nascimento,Num_titulo_eleitoral_candidato,Idade_data_eleicao,Codigo_sexo,Descricao_sexo,Cod_grau_instrucao,Descricao_grau_instrucao,Codigo_estado_civil,Descricao_estado_civil,Codigo_cor_raca,Descricao_cor_raca,Codigo_nacionalidade,Descricao_nacionalidade,Sigla_uf_nascimento,Codigo_municipio_nascimento,Nome_municipio_nascimento,Despesa_max_campanha,Cod_sit_tot_turno,Desc_sit_tot_turno,Nm_email")] ConsultaCandidato consultaCandidato)
        {
            if (ModelState.IsValid)
            {
                db.Entry(consultaCandidato).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(consultaCandidato);
        }

        // GET: ConsultaCandidatoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConsultaCandidato consultaCandidato = db.ConsultaCandidatoes.Find(id);
            if (consultaCandidato == null)
            {
                return HttpNotFound();
            }
            return View(consultaCandidato);
        }

        // POST: ConsultaCandidatoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ConsultaCandidato consultaCandidato = db.ConsultaCandidatoes.Find(id);
            db.ConsultaCandidatoes.Remove(consultaCandidato);
            db.SaveChanges();
            return RedirectToAction("Index");
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
