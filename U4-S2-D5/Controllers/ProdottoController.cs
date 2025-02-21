using Microsoft.AspNetCore.Mvc;
using U4_S2_D5.Services;

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
    }
}

