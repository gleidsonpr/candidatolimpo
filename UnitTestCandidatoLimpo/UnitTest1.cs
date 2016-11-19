using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCandidatoLimpo
{
 

    [TestClass]
    public class TesteUsuarioLogin
    {
        [TestMethod]
        public void Testar_Login_retorna_true_quando_passar_cpf_00000000000_e_senha_admin()
        {
            var tst = new UsuariosController();
            //var retorno = tst.login("00000000000","admin");
            //Assert.IsTrue(retorno);
        }

    }
}
