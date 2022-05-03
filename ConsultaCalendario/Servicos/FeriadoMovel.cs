using ConsultaCalendario.Models;


namespace ConsultaCalendario.Servicos
{
    public class FeriadoMovel
    {

        public static DiaDoCalendario ConsultarFeriadoMovel(int dia, int mes, int ano)
        {
            var a = (ano % 19);
            var b = (ano % 4);
            var c = (ano % 7);
            var d = (19 * a + 24) % 30;
            var e = ((2 * b) + (4 * c) + (6 * d) + 5) % 7;
            int diaPascoa;
            int mesPascoa;

            if(d + e > 9)
            {
                diaPascoa = (d + e - 9); 
                mesPascoa = 4;
            }
            else
            {
                diaPascoa = d + e + 22;
                mesPascoa = 3;
            }

            if(mesPascoa == 4 && diaPascoa == 26)
            {
                diaPascoa = 19;
            }

            if (mesPascoa == 4 && diaPascoa == 25 && d == 28 && a > 10) 
            {
                diaPascoa = 18;
            }

            var Pascoa = new DiaDoCalendario(diaPascoa, mesPascoa, ano, true, false, "Pascoa");

            if (dia == diaPascoa && mes == mesPascoa)
            {
                return Pascoa;
            }
            
            DateTime feriadoPascoa = new DateTime(ano, mesPascoa, diaPascoa);
            var carnaval = feriadoPascoa.AddDays(-47);
            var corpusChristi = feriadoPascoa.AddDays(+60);
            var sextaFeiraSanta = feriadoPascoa.AddDays(-2);
            //faltou sexta-feira santa que é 2 dias antes da pascoa

            var retornoCarnaval = new DiaDoCalendario(carnaval.Day, carnaval.Month, ano, true, false, "Carnaval");
            var retornoCorpusChristi = new DiaDoCalendario(corpusChristi.Day, corpusChristi.Month, ano, true, false, "Corpus Christi");
            var retornoSextaFeiraSanta = new DiaDoCalendario(sextaFeiraSanta.Day, sextaFeiraSanta.Month, ano, true, false, "Sexta-Feira Santa");
            var feriadoMovel = new DateTime(ano,mes,dia);
            
            if(feriadoMovel.CompareTo(carnaval) == 0)
            {
                return retornoCarnaval;
            }
            
            if (feriadoMovel.CompareTo(corpusChristi) == 0)
            {
                return retornoCorpusChristi;
            }

            if (feriadoMovel.CompareTo(sextaFeiraSanta) == 0)
            {
                return retornoSextaFeiraSanta;
            }

            return null;
        }
    }
}
