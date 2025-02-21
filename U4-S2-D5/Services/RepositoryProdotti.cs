using U4_S2_D5.Models;

namespace U4_S2_D5.Services
{
    public static class RepositoryProdotti
    {
       private static List<Prodotto> _prodotti = new List<Prodotto>
{
    new Prodotto 
    { 
        Id = Guid.NewGuid(),
        Nome = "Scarpa Sportiva Alpha", 
        Prezzo = 79.99m, 
        Descrizione = "Scarpa da ginnastica leggera e confortevole, ideale per l'allenamento quotidiano.",
        ImmagineCopertina = "/images/alpha.webp", 
        ImmaginiAggiuntive = new List<string> { "/images/alpha1.webp", "/images/alpha2.webp" } 
    },
    new Prodotto 
    { 
        Id = Guid.NewGuid(),
        Nome = "Scarpa Sportiva Beta", 
        Prezzo = 89.99m, 
        Descrizione = "Scarpa da corsa con ammortizzazione avanzata per una performance ottimale.",
        ImmagineCopertina = "/images/beta.webp", 
        ImmaginiAggiuntive = new List<string> { "/images/beta1.webp", "/images/beta2.webp" } 
    },
    new Prodotto 
    { 
        Id = Guid.NewGuid(),
        Nome = "Scarpa Sportiva Gamma", 
        Prezzo = 69.99m, 
        Descrizione = "Scarpa versatile per sport indoor, con supporto extra per le caviglie.",
        ImmagineCopertina = "/images/gamma.webp", 
        ImmaginiAggiuntive = new List<string> { "/images/gamma1.webp", "/images/gamma2.webp" } 
    },
};


        public static List<Prodotto> GetProdotti()
        {
            return _prodotti;
        }

        public static void AddProdotto(Prodotto prodotto)
        {
            prodotto.Id = Guid.NewGuid(); 
            _prodotti.Add(prodotto);
        }
    }



}
