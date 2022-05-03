namespace ConsultaCalendario.Models
{
    public class DiaDoCalendario
    {
        //Dia, Mes, ect aqui são propriedades
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public bool Feriado { get; set; }
        public string? NomeFeriado { get; set; }
        public bool DiaUtil { get; set; }
        public bool FimDeSemana { get; set; }

        //construtor
        //dia, mes ect aqui são parâmetros
        public DiaDoCalendario(int dia, int mes, int ano, bool feriado, bool diaUtil, string nomeFeriado)
        {
            Dia = dia;
            Mes = mes;
            Ano = ano;
            Feriado = feriado;
            NomeFeriado = nomeFeriado;
            DiaUtil = diaUtil;
            FimDeSemana = Servicos.FimDeSemana.ConsultarFimDeSemana(dia, mes, ano);

        }
        ////construtor para feriados de dia fixo, ou seja, não precisa do ano
        //public DiaDoCalendario(int dia, int mes, bool feriado, bool diaUtil, string nomeFeriado)
        //{
        //    Dia = dia;
        //    Mes = mes;
        //    Feriado = feriado;
        //    NomeFeriado = nomeFeriado;
        //    DiaUtil = diaUtil;
        //}
    }
}