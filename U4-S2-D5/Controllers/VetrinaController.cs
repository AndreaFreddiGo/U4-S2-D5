using Microsoft.AspNetCore.Mvc;
using U4_S2_D5.Services;
using U4_S2_D5.Models;
using System.Diagnostics;

namespace U4_S2_D5.Controllers
{
    public class VetrinaController : Controller
    {
        public IActionResult Index()
        {
            var prodotti = RepositoryProdotti.GetProdotti();

            Console.WriteLine("Numero di prodotti recuperati: " + prodotti.Count);

            Debug.WriteLine("Prodotti recuperati: " + prodotti.Count);
            foreach (var prodotto in prodotti)
            {
                Debug.WriteLine($"Prodotto: {prodotto.Nome}, Prezzo: {prodotto.Prezzo}");
            }
            return View("Index", prodotti);


        }
    }
}



