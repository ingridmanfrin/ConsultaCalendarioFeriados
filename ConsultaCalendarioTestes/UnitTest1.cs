using ConsultaCalendario.Controllers;
using ConsultaCalendario.Models;
using ConsultaCalendario.Servicos;
using System;
using Xunit;

namespace ConsultaCalendarioTestes
{
    public class UnitTest1
    {
        [Fact]
        public void TestFeriadoFixo()
        {
            var feriadoAnoNovo = FeriadoFixo.ConsultarFeriadoFixo(1, 1, 2022);

            //Assert.NotNull(feriadoAnoNovo);
            Assert.True(feriadoAnoNovo.Feriado == true);
            //Assert.NotEmpty(feriadoAnoNovo.NomeFeriado);
            Assert.True(feriadoAnoNovo.NomeFeriado == "Ano novo");

            var feriadoNatal = FeriadoFixo.ConsultarFeriadoFixo(25, 12, 2022);

            Assert.NotNull(feriadoNatal);
            Assert.True(feriadoNatal.Feriado == true);
            Assert.NotEmpty(feriadoNatal.NomeFeriado);
            Assert.True(feriadoNatal.NomeFeriado == "Natal");

            var feriadoIndependencia = FeriadoFixo.ConsultarFeriadoFixo(7, 9, 2022);

            Assert.NotNull(feriadoIndependencia);
            Assert.True(feriadoIndependencia.Feriado == true);
            Assert.NotEmpty(feriadoIndependencia.NomeFeriado);
            Assert.True(feriadoIndependencia.NomeFeriado == "Independência do Brasil");



        }

        [Fact]
        public void TestFeriadoMovel()
        {
            var feriadoMovel = FeriadoMovel.ConsultarFeriadoMovel(17, 4, 2022);

            Assert.NotNull(feriadoMovel);
            Assert.True(feriadoMovel.Feriado == true);
            Assert.NotEmpty(feriadoMovel.NomeFeriado);
        
        }

        [Fact]
        public void TestFimDeSemana()
        {
            var fimDeSemana = FimDeSemana.ConsultarFimDeSemana(7, 8, 2022);

            Assert.True(fimDeSemana.Equals(true));

        }

        [Fact]
        public void Test()
        {
            ConsultaCalendarioController consulta = new ConsultaCalendarioController();
            ConsultaCalendarioPost post = new ConsultaCalendarioPost();

            post.Dia = 6;
            post.Mes = 5;
            post.Ano = 2022;



            //Assert.True(consulta.ValidarDia(post);

        }

    }
}
    


