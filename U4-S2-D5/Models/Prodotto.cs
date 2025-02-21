namespace U4_S2_D5.Models
{
    public class Prodotto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Prezzo { get; set; }
        public string Descrizione { get; set; }
        public string ImmagineCopertina { get; set; }
        public List<string> ImmaginiAggiuntive { get; set; }

        public Prodotto()
        {
            Id = Guid.NewGuid();
        }
    }

}
