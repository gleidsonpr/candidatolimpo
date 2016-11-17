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

namespace candidatolimpo.Models
{
    public class ConsultaWebservices
    {

        string urlservidor = "http://webservicestecweb-net.umbler.net/api/";

        public List<Prefeito> consultaPrefeito(string uf, string cidade)
        {

            string url = urlservidor+"consultaprefeito/uf/" + uf + "/cidade/" + cidade;

            Uri uri = new Uri(@url);
            WebRequest webRequest = WebRequest.Create(uri);
            WebResponse response = webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            String sr = streamReader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Prefeito> lstpf = (List<Prefeito>)js.Deserialize(sr, typeof(List<Prefeito>));

            return lstpf;

        }

        public List<PerfilEleitor> consultaEleitorado(string nr_zona,string uf, string cidade)
        {

            string url = urlservidor+"consultaeleitorado/nr_zona/" + nr_zona +"/uf/"+uf+ "/municipio/" + cidade;

            Uri uri = new Uri(@url);
            WebRequest webRequest = WebRequest.Create(uri);
            WebResponse response = webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            String sr = streamReader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<PerfilEleitor> lstpfl = (List<PerfilEleitor>)js.Deserialize(sr, typeof(List<PerfilEleitor>));

            return lstpfl;

        }
        public List<Vereador> consultaVereadorCidade(string uf, string cidade)
        {

            string url = urlservidor+"consultavereador/uf/" + uf + "/cidade/" + cidade;

            Uri uri = new Uri(@url);
            WebRequest webRequest = WebRequest.Create(uri);
            WebResponse response = webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            String sr = streamReader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Vereador> lstvereador = (List<Vereador>)js.Deserialize(sr, typeof(List<Vereador>));

            return lstvereador;

        }
        public List<Vereador> consultaVereadorPartido(string uf, string cidade, string partido)
        {

            string url = urlservidor+"consultavereador/uf/" + uf + "/cidade/" + cidade + "/partido/" + partido;

            Uri uri = new Uri(@url);
            WebRequest webRequest = WebRequest.Create(uri);
            WebResponse response = webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            String sr = streamReader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Vereador> lstvereador = (List<Vereador>)js.Deserialize(sr, typeof(List<Vereador>));

            return lstvereador;

        }
        public List<Vereador> consultaVereadorSexo(string uf, string cidade, string sexo)
        {

            string url = urlservidor+"consultavereador/uf/" + uf + "/cidade/" + cidade + "/sexo/" + sexo;

            Uri uri = new Uri(@url);
            WebRequest webRequest = WebRequest.Create(uri);
            WebResponse response = webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            String sr = streamReader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Vereador> lstvereador = (List<Vereador>)js.Deserialize(sr, typeof(List<Vereador>));

            return lstvereador;

        }
        public List<Vereador> consultaVereadorEscolaridade(string uf, string cidade,string escolaridade)
        {

            string url = urlservidor+"consultavereador/uf/" + uf + "/cidade/" + cidade + "/escolaridade/" + escolaridade;

            Uri uri = new Uri(@url);
            WebRequest webRequest = WebRequest.Create(uri);
            WebResponse response = webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            String sr = streamReader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Vereador> lstvereador = (List<Vereador>)js.Deserialize(sr, typeof(List<Vereador>));

            return lstvereador;

        }
        public List<Vereador> consultaVereadorCombinacao(string uf, string cidade, string escolaridade,string sexo, string partido)
        {

            string url = urlservidor+"consultavereador/uf/" + uf + "/cidade/" + cidade + "/escolaridade/" + escolaridade + "/sexo/" + sexo + "/partido/" + partido;

            Uri uri = new Uri(@url);
            WebRequest webRequest = WebRequest.Create(uri);
            WebResponse response = webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            String sr = streamReader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Vereador> lstvereador = (List<Vereador>)js.Deserialize(sr, typeof(List<Vereador>));

            return lstvereador;

        }




        public List<Usuario> usuarioLogin(string cpf, string senha)
        {

            string url = urlservidor+"usuario/cpf/" + cpf + "/senha/" + senha;

            Uri uri = new Uri(@url);
            WebRequest webRequest = WebRequest.Create(uri);
            WebResponse response = webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            String sr = streamReader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Usuario> lstpf = (List<Usuario>)js.Deserialize(sr, typeof(List<Usuario>));

            return lstpf;

        }

    }
}