using EscrevendoNoCelular;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TesteConverterMensagem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConverterMensagem()
        {
            Assert.AreEqual("77773367_7773302_222337777_777766606660366656667889999_9999555337777", new ConversorTexto().converterMensagem("SEMPRE ACESSO O DOJOPUZZLES"));

        }

        [TestMethod]
        public void LimiteInvalido()
        {
            Assert.AreEqual("Limite inválido", new ConversorTexto().converterMensagem("wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww"));

        }
    }
}
