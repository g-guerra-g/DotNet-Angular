namespace ProEventos.Domain.Entities
{
    public class EventoPalestrante
    {
        public int Id { get; set; }
        public Evento Evento { get; set; }
        public int EventoId { get; set; }
        public Palestrante Palestrante { get; set; }
        public int PalestranteId { get; set; }
    }
}