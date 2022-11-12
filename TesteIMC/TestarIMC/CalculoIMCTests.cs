using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteIMC;

namespace TestarIMC
{
    //classe de testes
    [TestClass]
    public class CalculoIMCTests
    {
        //metodo de teste
        [TestMethod]
        public void CalcularIMC()
        {
            //Arrange - organizar e preparar o teste
            double peso = 110;
            double altura = 1.79;

            //Act - execução/chamada do método
            var resultadoIMC = Operacoes.CalcularIMC(peso, altura);

            //Assert - comportamento esperado, comportamento obtido
            Assert.AreEqual(34.33, resultadoIMC);
        }
    }
}
