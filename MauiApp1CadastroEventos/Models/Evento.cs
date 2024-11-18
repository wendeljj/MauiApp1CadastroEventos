namespace MauiApp1CadastroEventos.Models
{
    public class Evento
    {

        public required string NomeEvento { get; set; }

        public required string LocalEvento { get; set; }

        public int QntParticipantes { get; set; }

        public double CustoParticipantes { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataTermino { get; set; }

        public double ValorTotal 
        {
            get => CustoParticipantes * QntParticipantes;
        }

        public int DiasTotais
        {
            get => DataTermino.Subtract(DataInicio).Days;
        }

    }
}
