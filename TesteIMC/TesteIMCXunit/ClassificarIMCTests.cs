using TesteIMC;
using Xunit;

namespace TestarIMCXunit
{
    public class ClassificarIMCTests
    {
        //metodo de teste
        [Fact]
        public void ClassificarIMC_RetornaResultado()
        {

            //Arrange - organizar e preparar o teste
            double imc = 28;

            //Act - execução/chamada do método
            var classificacaoIMC = Operacoes.ClassificarIMC(imc);

            //Assert - comportamento esperado, comportamento obtido
            Assert.Equal("Sobrepeso", classificacaoIMC);
        }

        [Theory]
        [InlineData(28, "Sobrepeso")]
        [InlineData(31, "Obesidade Grau I")]
        public void ClassificarIMC_RetornaResultado_ParaUmaListaDeValores(double primeiroNumero, string resultadoEsperado)
        {
            var resultadoIMC = Operacoes.ClassificarIMC(primeiroNumero);

            Assert.Equal(resultadoEsperado, resultadoIMC);
        }

    }
   
}
