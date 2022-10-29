using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto_teste;

namespace TestMsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            //Arrange - preparação
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //Act - ação
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - verificação
            Assert.AreEqual(rNum, resultado);
        }

        //Arrange
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 1, 3)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act - ação
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - verificação
            Assert.AreEqual(rNum, resultado);
        }
    }
}