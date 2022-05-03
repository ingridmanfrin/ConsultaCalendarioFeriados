using ConsultaCalendario.Servicos;
using Xunit;

namespace ConsultaCalendarioTestes
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var feriadoFixo = FeriadoFixo.ConsultarFeriadoFixo(1, 1, 2022);

            Assert.NotNull(feriadoFixo);
            Assert.True(feriadoFixo.Feriado == true);
            Assert.NotEmpty(feriadoFixo.NomeFeriado);
            Assert.True(feriadoFixo.NomeFeriado == "Ano novo");

        }
    }
}