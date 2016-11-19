using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using candidatolimpo.Controllers;

namespace candidatolimpo.Models
{

    [TestClass]
    public class TesteUsuarioLogin
    {
        private UsuariosController tstUsuario;

        [TestInitialize]
        public void iniciarTestes()
        {
            tstUsuario = new UsuariosController();
        }

        [TestMethod]
        public void Login_retorna_true_quando_passar_cpf_00000000000_e_senha_admin()
        {           
            var retorno = tstUsuario.login("00000000000","admin");
            Assert.IsTrue(retorno);
        }
        [TestMethod]
        public void Login_retorna_false_quando_passar_cpf_555_e_senha_123()
        {            
            var retorno = tstUsuario.login("555", "123");
            Assert.IsFalse(retorno);
        }



    }
    [TestClass]
    public class TesteEleitores
    {
        private ConsultaWebservices tstEleitor;

        [TestInitialize]
        public void iniciarTestes()
        {
            tstEleitor = new ConsultaWebservices();
        }

        [TestMethod]
        public void Eleitores_retorna_maior_que_zero_quando_passar_zona_272_uf_sp_cidade_bertioga()
        {
            var retorno = tstEleitor.consultaEleitorado("272", "SP", "BERTIOGA");
            var tst = retorno.Count;
            Assert.AreNotEqual(tst, 0);          
        }
        [TestMethod]
        public void Eleitores_retorna__zero_quando_passar_zona_555_uf_sp_cidade_bertioga()
        {
            var retorno = tstEleitor.consultaEleitorado("555", "SP", "BERTIOGA");
            var tst = retorno.Count;
            Assert.AreEqual(tst, 0);
        }



    }

    [TestClass]
    public class TestePrefeitos
    {
        private ConsultaWebservices tstPrefeito;

        [TestInitialize]
        public void iniciarTestes()
        {
            tstPrefeito = new ConsultaWebservices();
        }

        [TestMethod]
        public void Prefeitos_retorna_maior_que_zero_quando_passar_uf_MG_cidade_BELO_HORIZONTE()
        {
            var retorno = tstPrefeito.consultaPrefeito("MG", "BELO HORIZONTE");
            var tst = retorno.Count;
            Assert.AreNotEqual(tst, 0);
        }
        [TestMethod]
        public void Prefeitos_eleitores_retorna__zero_quando_passar_uf_mg_cidade_bertioga()
        {
            var retorno = tstPrefeito.consultaPrefeito("MG", "BERTIOGA");
            var tst = retorno.Count;
            Assert.AreEqual(tst, 0);
        }



    }
}
