using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteIMC;

namespace TestarIMC
{
    //classe de testes
    [TestClass]
    public class ClassificarIMCTests
    {
        //metodo de teste
        [TestMethod]
        public void ClassificarIMC()
        {
            //Arrange - organizar e preparar o teste
            double imc = 28;

            //Act - execução/chamada do método
            var classificacaoIMC = Operacoes.ClassificarIMC(imc);

            //Assert - comportamento esperado, comportamento obtido
            Assert.AreEqual("Sobrepeso", classificacaoIMC);
        }
    }
}
