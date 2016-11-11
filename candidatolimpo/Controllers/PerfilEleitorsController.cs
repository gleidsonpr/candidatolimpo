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

namespace candidatolimpo.Controllers
{
    public class PerfilEleitorsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PerfilEleitors
        public ActionResult Index()
        {
            consultaWebService();
            List<PerfilEleitor> pfl = new List<PerfilEleitor>();
            return View(pfl);
        }

        // GET: PerfilEleitors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PerfilEleitor perfilEleitor = db.PerfilEleitors.Find(id);
            if (perfilEleitor == null)
            {
                return HttpNotFound();
            }
            return View(perfilEleitor);
        }

        // GET: PerfilEleitors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PerfilEleitors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Periodo,Uf,Municipio,Sexo,Faixa_etaria,Grau_de_escolaridade,Cod_municipio_tse,Nr_zona,Qtd_eletores_no_perfil")] PerfilEleitor perfilEleitor)
        {
            if (ModelState.IsValid)
            {
                db.PerfilEleitors.Add(perfilEleitor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(perfilEleitor);
        }

        // GET: PerfilEleitors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PerfilEleitor perfilEleitor = db.PerfilEleitors.Find(id);
            if (perfilEleitor == null)
            {
                return HttpNotFound();
            }
            return View(perfilEleitor);
        }

        // POST: PerfilEleitors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Periodo,Uf,Municipio,Sexo,Faixa_etaria,Grau_de_escolaridade,Cod_municipio_tse,Nr_zona,Qtd_eletores_no_perfil")] PerfilEleitor perfilEleitor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(perfilEleitor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(perfilEleitor);
        }

        // GET: PerfilEleitors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PerfilEleitor perfilEleitor = db.PerfilEleitors.Find(id);
            if (perfilEleitor == null)
            {
                return HttpNotFound();
            }
            return View(perfilEleitor);
        }

        // POST: PerfilEleitors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PerfilEleitor perfilEleitor = db.PerfilEleitors.Find(id);
            db.PerfilEleitors.Remove(perfilEleitor);
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
        protected List<PerfilEleitor> consultaWebService()
        {
            Uri uri = new Uri(@"http://trabalhofinal-com.umbler.net/api/consultaeleitorado/1");
            WebRequest webRequest = WebRequest.Create(uri);
            WebResponse response = webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            String responseData = streamReader.ReadToEnd();



            //Console.WriteLine(responseData);


            //WebRequest request = WebRequest.Create(
            //  "http://trabalhofinal-com.umbler.net/api/user");

            //WebResponse response = request.GetResponse();

            //Console.WriteLine(((HttpWebResponse)response).StatusDescription);


            //// Get the stream containing content returned by the server.
            //Stream dataStream = response.GetResponseStream();
            //// Open the stream using a StreamReader for easy access.
            //StreamReader reader = new StreamReader(dataStream);
            //// Read the content.
            //string responseFromServer = reader.ReadToEnd();
            //// Display the content.
            //Console.WriteLine(responseFromServer);
            //// Clean up the streams and the response.
            //reader.Close();
            //response.Close();




            //HttpWebRequest request2 = (HttpWebRequest)WebRequest.Create("http://trabalhofinal-com.umbler.net/api/user");
            //string text;
            //var response3 = (HttpWebResponse)request.GetResponse();

            //using (var sr = new StreamReader(response3.GetResponseStream()))
            //{
            //    text = sr.ReadToEnd();
            //}



            //JArray array = new JArray();
            //using (var twitpicResponse = (HttpWebResponse)request.GetResponse())
            //{

            //    using (var reader2 = new StreamReader(twitpicResponse.GetResponseStream()))
            //    {
            //        JavaScriptSerializer js = new JavaScriptSerializer();
            //        var objText = reader.ReadToEnd();

            //        JObject joResponse = JObject.Parse(objText);
            //        JObject result = (JObject)joResponse["result"];
            //        array = (JArray)result["Detail"];
            //        string statu = array[0]["dlrStat"].ToString();
            //    }

            //}

            return null;

        }
    }
}
