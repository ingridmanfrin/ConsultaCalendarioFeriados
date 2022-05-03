using ConsultaCalendario.Models;

namespace ConsultaCalendario.Servicos
{
    public class FimDeSemana
    {
        public static bool ConsultarFimDeSemana(int dia, int mes, int ano)
        {
            DateTime data = new DateTime(ano, mes, dia);
            if(data.DayOfWeek == DayOfWeek.Sunday || data.DayOfWeek == DayOfWeek.Saturday) //primeiro dayofwich é uma propriedade do obejeto data e o segundo é um enun
            {
                return true;
               
            }
            return false;   
        }
    }
}
