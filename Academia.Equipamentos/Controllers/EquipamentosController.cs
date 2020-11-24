using Academia.Equipamentos.Dados.Entity.Context;
using Academia.Equipamentos.Dominio;
using Academia.Equipamentos.Repositorios.Comum;
using Academia.Equipamentos.Repositorios.Entity;
using Academia.Equipamentos.ViewModels.Equipamento;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Academia.Equipamentos.Controllers
{
    public class EquipamentosController : Controller
    {
        private IRepositorioGenerico<Equipamento, int>
             repositorioEquipamentos = new EquipamentosRepositorio(new EquipamentoDbContext());

        // GET: Filmes
        public ActionResult Index()
        {
            // var filmes = db.Filmes.Include(f => f.Album);
            return View(Mapper.Map<List<Equipamento>,
                         List<EquipamentoIndexViewModel>>(repositorioEquipamentos.Selecionar()));
        }

        // GET: Filmes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Equipamento filme = repositorioEquipamentos.SelecionarPorId(id.Value);
            if (filme == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Equipamento, EquipamentoIndexViewModel>(filme));
        }

        // POST: Filmes/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdFilme,NomeFilme,IdAlbum")] EquipamentoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Equipamento filme = Mapper.Map<EquipamentoViewModel, Equipamento>(viewModel);
                repositorioEquipamentos.Inserir(filme);
                return RedirectToAction("Index");
            }

            //ViewBag.IdAlbum = new SelectList(db.Albuns, "Id", "Nome", filme.IdAlbum);
            return View(viewModel);
        }

        // GET: Filmes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Equipamento filme = repositorioEquipamentos.SelecionarPorId(id.Value);
            if (filme == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Equipamento, EquipamentoViewModel>(filme));
        }

        // POST: Filmes/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdFilme,NomeFilme,IdAlbum")] EquipamentoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Equipamento filme = Mapper.Map<EquipamentoViewModel, Equipamento>(viewModel);
                repositorioEquipamentos.Alterar(filme);
                return RedirectToAction("Index");
            }
            //ViewBag.IdAlbum = new SelectList(db.Albuns, "Id", "Nome", filme.IdAlbum);
            return View(viewModel);
        }

        // GET: Filmes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Equipamento filme = repositorioEquipamentos.SelecionarPorId(id.Value);
            if (filme == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Equipamento, EquipamentoIndexViewModel>(filme));
        }

        // POST: Filmes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            repositorioEquipamentos.ExcluirPorId(id);
            return RedirectToAction("Index");
        }
    }
}