using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoModeloDDD.Application.Interfaces;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IProdutoAppService _produtoApp;
        private readonly IClienteAppService _clienteApp;

        public ProdutosController(IProdutoAppService produtoApp, IClienteAppService clienteApp)
        {
            _produtoApp = produtoApp;
        }

        // GET: Produtos
        public ActionResult Index()
        {
            var ProdutoViewModel = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoApp.GetAll());
            return View(ProdutoViewModel);
        }

        // GET: Produtos/Details/5
        public ActionResult Details(int id)
        {
            var Produto = _produtoApp.GetById(id);
            var ProdutoViewModel = Mapper.Map<Produto, ProdutoViewModel>(Produto);

            return View(ProdutoViewModel);
        }

        // GET: Produtos/Create
        public ActionResult Create()
        {
            //montagem de dropdownlist
            ViewBag.ClienteId = new SelectList(_clienteApp.GetAll(), "ClienteId", "Nome");
            return View();
        }

        // POST: Produtos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel Produto)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    var ProdutoDomain = Mapper.Map<ProdutoViewModel, Produto>(Produto);
                    _produtoApp.Add(ProdutoDomain);

                    return RedirectToAction("Index");
                }

                return View(Produto);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Especiais(string nome)
        {
            var ProdutoViewModel = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoApp.BuscarPorNome(nome));

            return View(ProdutoViewModel);
        }

        // GET: Produtos/Edit/5
        public ActionResult Edit(int id)
        {
            var Produto = _produtoApp.GetById(id);
            var ProdutoViewModel = Mapper.Map<Produto, ProdutoViewModel>(Produto);

            return View(ProdutoViewModel);
        }

        // POST: Produtos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoViewModel Produto)
        {
            if (ModelState.IsValid)
            {
                var ProdutoDomain = Mapper.Map<ProdutoViewModel, Produto>(Produto);
                _produtoApp.Update(ProdutoDomain);

                return RedirectToAction("Index");
            }

            return View(Produto);
        }

        // GET: Produtos/Delete/5
        public ActionResult Delete(int id)
        {
            var Produto = _produtoApp.GetById(id);
            var ProdutoViewModel = Mapper.Map<Produto, ProdutoViewModel>(Produto);

            return View(ProdutoViewModel);
        }

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var Produto = _produtoApp.GetById(id);
            _produtoApp.Remove(Produto);

            return RedirectToAction("Index");
        }
    }
}