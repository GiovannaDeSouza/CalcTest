namespace Calculadora.Tests
{
    public class CalculadoraTest
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(5, CalculadoraExample.Calculadora.Somar(2, 3));
       
            Assert.Equal(1, CalculadoraExample.Calculadora.Subtrair(3, 2));
      
            Assert.Equal(2, CalculadoraExample.Calculadora.Dividir(4, 2));
        
            Assert.Equal(6, CalculadoraExample.Calculadora.Multiplicar(2, 3));
        }

    }
}