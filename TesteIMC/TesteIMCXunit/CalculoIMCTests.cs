using TesteIMC;
using Xunit;

namespace TestarIMCXunit
{
    public class CalculoIMC
    {
        //metodo de teste
        [Fact]
        public void CalcularIMC_RetornaResultado()
        {
            //Arrange - organizar e preparar o teste
            double peso = 110;
            double altura = 1.79;

            //Act - execução/chamada do método
            var resultadoIMC = Operacoes.CalcularIMC(peso, altura);

            //Assert - comportamento esperado, comportamento obtido
            Assert.Equal(34.33, resultadoIMC);
        }
        [Theory]
        [InlineData(80,1.79,24.97)]
        [InlineData(100, 1.79, 31.21)]
        public void CalcularIMC_RetornaResultado_ParaUmaListaDeValores(double primeiroNumero, double segundoNumero, double resultadoEsperado)
        {
            var resultadoIMC = Operacoes.CalcularIMC(primeiroNumero, segundoNumero);

            Assert.Equal(resultadoEsperado, resultadoIMC);
        }
    }
  
}
