using primer_parcial_unit_test_procesador_matematico;
using Xunit;

namespace TestingProcesadorMatematico
{
    public class TestingSumar
    {
        [Fact]
        public void Sumar_ValoresPositivos_ValorEsperado()
        {
            ProcesadorMatematico calculando = new ProcesadorMatematico();
            int resultadoInicial = calculando.Sumar(2,2);

            int resultadoEsperado = 4;

            Assert.Equal(resultadoInicial, resultadoEsperado);
        }
        [Fact]
        public void Sumar_ValoresNegativos_ValorEsperado()
        {
            ProcesadorMatematico calculando = new ProcesadorMatematico();
            int resultadoInicial = calculando.Sumar(-2, -2);

            int resultadoEsperado = -4;

            Assert.Equal(resultadoInicial, resultadoEsperado);
        }

    }
}