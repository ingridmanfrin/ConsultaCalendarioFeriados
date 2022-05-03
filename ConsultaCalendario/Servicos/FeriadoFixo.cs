using ConsultaCalendario.Models;
using System.Linq;

namespace ConsultaCalendario.Servicos
{
    public class FeriadoFixo
    {
       //public List<DiaDoCalendario> lista = new List<DiaDoCalendario>(); preciso resolver para deixar isso public a todos aos metododos
        //o static faz com que eu não tenha que instanciar a classe FeriadoFixo em outro local.
        public static DiaDoCalendario ConsultarFeriadoFixo(int dia, int mes, int ano)
        {
            List<DiaDoCalendario> lista = new List<DiaDoCalendario>();
            lista.Add(new DiaDoCalendario(1, 1, ano, true, false, "Ano novo"));
            lista.Add(new DiaDoCalendario(21, 4, ano, true, false, "Tiradentes"));
            lista.Add(new DiaDoCalendario(1, 5, ano, true, false, "Dia do Trabalho"));
            lista.Add(new DiaDoCalendario(7, 9, ano, true, false, "Independência do Brasil"));
            lista.Add(new DiaDoCalendario(12, 10, ano, true, false, "Nossa Senhora Aparecida"));
            lista.Add(new DiaDoCalendario(2, 11, ano, true, false, "Finados"));
            lista.Add(new DiaDoCalendario(15, 11, ano, true, false, "Proclamação da República"));
            lista.Add(new DiaDoCalendario(20, 11, ano, true, false, "Zumbi e Consciência Negra"));
            lista.Add(new DiaDoCalendario(25, 12, ano, true, false, "Natal"));

            var retorno = lista.FirstOrDefault(feriado => feriado.Dia == dia && feriado.Mes == mes);
            
            return retorno;
        }
        
    }
}

//FirstOrDefault: retorna o primeiro que achar dentro da condição imposta,
//                ou (or) retorna null (Default).
//pode ser criado varios methodos 