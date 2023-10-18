using DesafioCalculadora.Services;

namespace DesafioCalculadoraTests
{
    public class UnitTest1
    {
        private Calculadora _calc;
        public UnitTest1()
        {
            _calc = new Calculadora();
        }
        [Theory]
        [InlineData(10,5,15)]
        [InlineData(10,10,20)]
        [InlineData(10,2,12)]
        public void SomarTeste(int num1,int num2, int resultado)
        {
            int result = _calc.Somar(num1, num2);

            Assert.Equal(resultado, result);

        }
        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(10, 10, 0)]
        [InlineData(10, 2, 8)]
        public void SubtrairTeste(int num1, int num2, int resultado)
        {
            int result = _calc.Subtrair(num1, num2);

            Assert.Equal(resultado, result);

        }
        [Theory]
        [InlineData(10, 5, 50)]
        [InlineData(10, 10, 100)]
        [InlineData(10, 2, 20)]
        public void MultiplicarTeste(int num1, int num2, int resultado)
        {
            int result = _calc.Multiplicar(num1, num2);

            Assert.Equal(resultado, result);

        }
        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(10, 10, 1)]
        [InlineData(10, 2, 5)]
        public void DividirTeste(int num1, int num2, int resultado)
        {
            int result = _calc.Dividir(num1, num2);

            Assert.Equal(resultado, result);

        }
        [Fact]
        
        public void DividirPorZeroTeste()
        {
            
            Assert.Throws<DivideByZeroException>(()=> _calc.Dividir(10,0));

        }
        [Fact]
        public void HistoricoTeste()
        {
            _calc.Somar(10, 2);
            _calc.Somar(10, 12);
            _calc.Somar(10, 22);
            _calc.Somar(10, 32);
            List<string> lista = _calc.Historico();
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);

        }
    }
}