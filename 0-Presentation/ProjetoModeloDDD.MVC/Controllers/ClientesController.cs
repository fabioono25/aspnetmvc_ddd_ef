using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.Repositories;
using ProjetoModeloDDD.MVC.Models;
using ProjetoModeloDDD.MVC.ViewModels;


namespace ProjetoModeloDDD.MVC.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ClienteRepository _clienteRepository = new ClienteRepository();

        public ActionResult Index()
        {
            var clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteRepository.GetAll());
            return View(clienteViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel cliente){
            
            if (!ModelState.IsValid)
                return View(cliente);

            var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(cliente);
            _clienteRepository.Add(clienteDomain);

            return RedirectToAction("Index");
        }
    }
}