using System;
using Biblioteca.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Biblioteca.Controllers
{
    
    public class EmprestimoController : Controller
    {
        public IActionResult Cadastro()
        {
            Autenticacao.CheckLogin(this);
            LivroService livroService = new LivroService();
            EmprestimoService emprestimoService = new EmprestimoService();

            CadEmprestimoViewModel cadModel = new CadEmprestimoViewModel();
            cadModel.Livros = livroService.ListarTodos();
            return View(cadModel);
        }

        [HttpPost]
        public IActionResult Cadastro(CadEmprestimoViewModel viewModel)
        {
            EmprestimoService emprestimoService = new EmprestimoService();
            
            if(viewModel.Emprestimo.Id == 0)
            {
                emprestimoService.Inserir(viewModel.Emprestimo);
            }
            else
            {
                emprestimoService.Atualizar(viewModel.Emprestimo);
            }
            return RedirectToAction("Listagem");
        }

        public IActionResult Listagem(string TipoFiltro, string Filtro, int p = 1)
        {
            Autenticacao.CheckLogin(this);
            FiltrosEmprestimos objFiltro = null;
            if(!string.IsNullOrEmpty(Filtro))
            {
                objFiltro = new FiltrosEmprestimos();
                objFiltro.Filtro = Filtro;
                objFiltro.TipoFiltro = TipoFiltro;
            }

            int quantidadePorPagina = 10;
            EmprestimoService emprestimo = new EmprestimoService();
            int totalDeRegistro = emprestimo.NumeroDeEmprestimos();
            ICollection<Emprestimo> listaem = emprestimo.ListarTodos(p, quantidadePorPagina, objFiltro);
            ViewData["NroPaginas"] = (int) Math.Ceiling((double) totalDeRegistro / quantidadePorPagina);
            return View(listaem);
        }
        

        public IActionResult Edicao(int id)
        {
            LivroService livroService = new LivroService();
            EmprestimoService em = new EmprestimoService();
            Emprestimo e = em.ObterPorId(id);

            CadEmprestimoViewModel cadModel = new CadEmprestimoViewModel();
            cadModel.Livros = livroService.ListarTodos();
            cadModel.Emprestimo = e;
            
            return View(cadModel);
        }
    }
}