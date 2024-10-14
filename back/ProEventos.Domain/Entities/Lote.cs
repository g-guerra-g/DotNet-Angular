namespace ProEventos.Domain.Entities
{
    public class Lote
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public Evento Evento { get; set; }
        public int EventoId { get; set; }
    }
}