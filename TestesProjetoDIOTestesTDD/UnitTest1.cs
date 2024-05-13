using ProjetoDIOTestesTDD;
using System;
using Xunit;

namespace TestesProjetoDIOTestesTDD
{
    public class UnitTest1
    {
        public Calculadora construirClasse() 
        {
            DateTime dataAtual = DateTime.Now; // Obtém a data atual

            string dataFormatada = dataAtual.ToString("dd/MM/yyyy");

            Calculadora calculadora = new Calculadora(dataFormatada);

            return calculadora;
        }

        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (4, 5, 9)]
        public void TesteSomar(int val1, int val2, int resultado)
        {
            Calculadora calculadora = construirClasse();

            int resultadoCalculadora = calculadora.somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(7, 2, 5)]
        [InlineData(12, 5, 7)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calculadora = construirClasse();

            int resultadoCalculadora = calculadora.subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar (int val1, int val2, int resultado)
        {
            Calculadora calculadora = construirClasse();

            int resultadoCalculadora = calculadora.multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(8, 2, 4)]
        [InlineData(25, 5, 5)]
        public void TesteDividir (int val1, int val2, int resultado)
        {
            Calculadora calculadora = construirClasse();  

            int resultadoCalculadora = calculadora.dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]

        public void TestarDivisaoPorZero()
        {
            Calculadora calculadora = construirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calculadora.dividir(3, 0)
                );
        }

        [Fact]

        public void TestarHistoricoCalculos()
        {
            Calculadora calculadora = construirClasse();

            calculadora.somar(2, 3);
            calculadora.somar(9, 3);
            calculadora.somar(6, 7);
            calculadora.somar(1, 8);

            var lista = calculadora.historicoCalculos();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
