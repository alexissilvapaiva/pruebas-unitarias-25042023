using primer_parcial_unit_test_procesador_matematico;
using Xunit;

namespace TestingProcesadorMatematico
{
    public class TestingMayor
    {
        [Fact]
        public void Segundo_Num_devuelveTrue()
        {
            ProcesadorMatematico calculando = new ProcesadorMatematico();
            int valorInicial = calculando.CalcularMayor(6,5);

            int valorEseprado = 6;

            Assert.Equal(valorInicial, valorEseprado);
        }

        [Fact]
        public void Primer_Num_devuelveTrue()
        {
            ProcesadorMatematico calculando = new ProcesadorMatematico();
            int valorInicial = calculando.CalcularMayor(5, 6);

            int valorEseprado = 6;

            Assert.Equal(valorInicial, valorEseprado);
        }

        [Fact]
        public void NumerosIguales_True()
        {
            ProcesadorMatematico calculando = new ProcesadorMatematico();
            int valorInicial = calculando.CalcularMayor(14, 14);

            int valorEseprado = 14;

            Assert.Equal(valorInicial, valorEseprado);

        }
    }
}
