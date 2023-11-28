using Jogos.Model.Models;
using Jogos.Model.Services;
using Microsoft.AspNetCore.Mvc;

namespace Categorias.Controllers
{
    public class CategoriaController : Controller
    {
        private ServiceCategoria _ServiceCategoria;

        public CategoriaController()
        {
            _ServiceCategoria = new ServiceCategoria();
        }

        public async Task<IActionResult> Index()
        {
            var ListaCategorias = await _ServiceCategoria.oRepositoryCategoria.SelecionarTodosAsync();
            return View(ListaCategorias);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                categoria = await _ServiceCategoria.oRepositoryCategoria.IncluirAsync(categoria);
                return View(categoria);
            }
            return View();
        }

        public async Task<ActionResult> Edit(int id)
        {
            var Categoria = await _ServiceCategoria.oRepositoryCategoria.SelecionarPkAsync(id);
            return View(Categoria);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Categoria Categoria)
        {
            if (ModelState.IsValid)
            {
                Categoria = await _ServiceCategoria.oRepositoryCategoria.AlterarAsync(Categoria);
                return View(Categoria);
            }
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _ServiceCategoria.oRepositoryCategoria.ExcluirAsync(id);
            return RedirectToAction("Index");

        }

        public async Task<ActionResult> Details(int id)
        {
            var Categoria = await _ServiceCategoria.oRepositoryCategoria.SelecionarPkAsync(id);

            return View(Categoria);
        }
    }
}
