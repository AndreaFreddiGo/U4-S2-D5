using Microsoft.AspNetCore.Mvc;
using U4_S2_D5.Services;
using U4_S2_D5.Models;
using System;
using System.Linq;

namespace U4_S2_D5.Controllers
{
    public class ProdottoController : Controller
    {
        public IActionResult Dettagli(Guid id)
        {
            var prodotto = RepositoryProdotti.GetProdotti().FirstOrDefault(p => p.Id == id);
            if (prodotto == null)
            {
                return NotFound();
            }
            return View(prodotto);
        }

        public IActionResult Modifica(Guid id)
        {
            var prodotto = RepositoryProdotti.GetProdotti().FirstOrDefault(p => p.Id == id);
            if (prodotto == null) return NotFound();
            return View(prodotto);
        }

        [HttpPost]
        public IActionResult Modifica(Prodotto prodotto)
        {
            var prodotti = RepositoryProdotti.GetProdotti();
            var index = prodotti.FindIndex(p => p.Id == prodotto.Id);
            if (index != -1)
            {
                prodotti[index] = prodotto;
                return RedirectToAction("Dettagli", new { id = prodotto.Id });
            }
            return View(prodotto);
        }

        public IActionResult Elimina(Guid id)
        {
            var prodotti = RepositoryProdotti.GetProdotti();
            var prodotto = prodotti.FirstOrDefault(p => p.Id == id);
            if (prodotto != null)
            {
                prodotti.Remove(prodotto);
            }
            return RedirectToAction("Index", "Vetrina");
        }
    }
}

