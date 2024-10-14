namespace ProEventos.Domain.Entities
{
    public class RedeSocial
    {
        public int Id { get; set; }
        public string UrlRedeSocial { get; set; }
        public string ImagemUrl { get; set; }
        public Evento Evento { get; set; }
        public int EventoId { get; set; }
        public Palestrante Palestrante { get; set; }
        public int PalestranteId { get; set; }
    }
}