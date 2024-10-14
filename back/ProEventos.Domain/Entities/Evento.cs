namespace ProEventos.Domain.Entities
{
    public class Evento
    {
        public int Id { get; set; }
        public string TemaEvento { get; set; }
        public DateTime? DataEvento { get; set; }
        public string LocalEvento { get; set; }
        public Lote Lotes { get; set; }
        public RedeSocial RedesSociais { get; set; }
        public EventoPalestrante EventosPalestrantes { get; set; }
    }
}