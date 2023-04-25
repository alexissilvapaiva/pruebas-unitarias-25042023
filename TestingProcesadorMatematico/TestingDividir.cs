using primer_parcial_unit_test_procesador_matematico;
using Xunit;

namespace TestingProcesadorMatematico
{
    public class TestingDividir
    {
        [Fact]
        public void Dividiendo_valoresPositivos_ValorEsperado()
        {
            ProcesadorMatematico calculando = new ProcesadorMatematico();
            int result_inicial = calculando.Dividir(2, 2);


            int resultado_esperado = 1;

            Assert.Equal(result_inicial, resultado_esperado);  
        }

        [Fact]
        public void Divisor_porCero_ValorEsperado()
        {
            ProcesadorMatematico calculando = new ProcesadorMatematico();
            int result_inicial = calculando.Dividir(40, 0);


            int resultado_esperado = -1;

            Assert.Equal(result_inicial, resultado_esperado);
        }

        [Fact]
        public void Dividiendo_Cero_ValorEsperado()
        {
            ProcesadorMatematico calculando = new ProcesadorMatematico();
            int result_inicial = calculando.Dividir(0, 40);


            int resultado_esperado = 0;

            Assert.Equal(result_inicial, resultado_esperado);
        }
    }
}
