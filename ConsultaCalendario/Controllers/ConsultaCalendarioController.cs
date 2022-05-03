using ConsultaCalendario.Models;
using ConsultaCalendario.Servicos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsultaCalendario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaCalendarioController : ControllerBase
    {
        [HttpPost]
        public IActionResult ValidarDia(ConsultaCalendarioPost data)
        {
            int dia, mes, ano;
            dia = data.Dia;
            mes = data.Mes; 
            ano = data.Ano; 

            try
            {
                var validaDate = new DateTime(ano, mes, dia);
                
            }
            catch (Exception ex)
            {
                return BadRequest("Data inválida.");
            }

            if(ano < 1901 || ano > 2099)
            {
                return BadRequest("Ano deve estar entre 1901 e 2099.");    
            }

            var feriadoFixo = FeriadoFixo.ConsultarFeriadoFixo(dia, mes, ano);
            var feriadoMovel = FeriadoMovel.ConsultarFeriadoMovel(dia, mes, ano);
            var fimDeSemana = FimDeSemana.ConsultarFimDeSemana(dia, mes, ano);

            if (feriadoFixo != null )
            {
                //é feriado 
                //return Ok($"Não é dia Útil. É feriado de {feriadoFixo.NomeFeriado}.");
                return Ok(feriadoFixo);
            }
            if (feriadoMovel != null)
            {
                //é feriado 
                //return Ok($"Não é dia Útil. É feriado de {feriadoMovel.NomeFeriado}.");
                return Ok(feriadoMovel);
            }
            if (fimDeSemana == true)
            {
                //é fim de semana
                //return Ok("Não é dia Útil. É fim de semana.");
                var DiaDoCalendario = new DiaDoCalendario(dia, mes, ano, false, false, null);
                return Ok(DiaDoCalendario);
            }

            var DiaUtilCalendario = new DiaDoCalendario(dia, mes, ano, false, true, null);
            return Ok(DiaUtilCalendario);
        }
    }
}
