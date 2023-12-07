using Jogos.Model.Models;
using Jogos.Model.Services;
using Jogos.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Jogos.Controllers
{
    [Authorize]
    public class JogoCategoriaController : Controller
    {
        public ServiceJogoCategoria _ServiceJogoCategoria;

        public JogoCategoriaController()
        {
            _ServiceJogoCategoria = new ServiceJogoCategoria();
        }

        public async Task<IActionResult> Index()
        {
            var ListaJogoCategorias = await _ServiceJogoCategoria.oRepositoryJogoCategoria.SelecionarTodosAsync();
            return View(ListaJogoCategorias);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(JogosCategoria jogoCategoria)
        {
            if (ModelState.IsValid)
            {
                jogoCategoria = await _ServiceJogoCategoria.oRepositoryJogoCategoria.IncluirAsync(jogoCategoria);
                return View(jogoCategoria);
            }
            return View();
        }

        public async Task<ActionResult> Edit(int id)
        {
            var JogoCategoria = await _ServiceJogoCategoria.oRepositoryJogoCategoria.SelecionarPkAsync(id);
            return View(JogoCategoria);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(JogosCategoria JogoCategoria)
        {
            if (ModelState.IsValid)
            {
                JogoCategoria = await _ServiceJogoCategoria.oRepositoryJogoCategoria.AlterarAsync(JogoCategoria);
                return View(JogoCategoria);
            }
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _ServiceJogoCategoria.oRepositoryJogoCategoria.ExcluirAsync(id);
            return RedirectToAction("Index");

        }

        public async Task<ActionResult> Details(int id)
        {
            var JogoCategoria = await _ServiceJogoCategoria.oRepositoryJogoCategoria.SelecionarPkAsync(id);

            return View(JogoCategoria);
        }
        
        public void CarregaViewBag()
        {
            ViewData["JogoId"] = new SelectList(_ServiceJogoCategoria.oRepositoryJogo.SelecionarTodos(), "JogoId", "Nome");
            ViewData["CategoriaId"] = new SelectList(_ServiceJogoCategoria.oRepositoryCategoria.SelecionarTodos(), "CategoriaId", "Nome");
            ViewBag.listaJogoCategoria = _ServiceJogoCategoria.oRepositoryJogo.SelecionarTodos();
        }

        public IActionResult Manter() 
        {
            CarregaViewBag();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Manter(JogoCategoriaVM jogoCategoriaVM)
        {
            try
            {
                
                foreach (var item in jogoCategoriaVM.ListaJogoCategoria)
                {
                    var jogoCategoria = new JogosCategoria()
                    {
                        CategoriaId = jogoCategoriaVM.CategoriaId,
                        JogoId = jogoCategoriaVM.JogoId
                    };
                await _ServiceJogoCategoria.oRepositoryJogoCategoria.IncluirAsync(jogoCategoria);
                }

            } 
            catch (Exception ex) 
            {
            
            }
            CarregaViewBag();
            return View();
        }


    }
}
