namespace ProEventos.Domain.Entities
{
    public class Palestrante
    {
        public int Id { get; set; }   
        public string Nome { get; set; }
        public string Curriculo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public RedeSocial RedesSociais { get; set; }
        public EventoPalestrante EventosPalestrantes { get; set; }
    }
}