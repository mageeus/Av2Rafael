using Jogos.Model.Models;
using Jogos.Model.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Jogos.Controllers
{
    [Authorize]
    public class JogoController : Controller
    {
        private ServiceJogo _ServiceJogo;

        public JogoController()
        {
            _ServiceJogo = new ServiceJogo();
        }

        public async Task<IActionResult> Index()
        {
            var ListaJogos = await _ServiceJogo.oRepositoryJogo.SelecionarTodosAsync();
            return View(ListaJogos);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Jogo jogo)
        {
            if(ModelState.IsValid)
            {
                jogo = await _ServiceJogo.oRepositoryJogo.IncluirAsync(jogo);
                return View(jogo);
            }
            return View();
        }

        public async Task<ActionResult> Edit(int id)
        {
            var jogo = await _ServiceJogo.oRepositoryJogo.SelecionarPkAsync(id);
            return View(jogo);
        }
        
        [HttpPost]
        public async Task<IActionResult> Edit(Jogo jogo)
        {
            if (ModelState.IsValid)
            {
                jogo = await _ServiceJogo.oRepositoryJogo.AlterarAsync(jogo);
                return View(jogo);
            }
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _ServiceJogo.oRepositoryJogo.ExcluirAsync(id);
            return RedirectToAction("Index");

        }

        public async Task<ActionResult> Details(int id)
        {
            var jogo = await _ServiceJogo.oRepositoryJogo.SelecionarPkAsync(id);

            return View(jogo);
        }
    }
}
