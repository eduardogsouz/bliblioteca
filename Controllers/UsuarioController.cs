using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace Biblioteca.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult ListaDeUsers()
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaLoginAdmin(this);

            return View(new UsuarioService().Listar());
        }

        public IActionResult editarUser(int id)
        {
            Usuario u = new UsuarioService().Listar(id);
            return View(u);
        }

        [HttpPost]
        public IActionResult editarUser(Usuario edituser)
        {
            UsuarioService us = new UsuarioService();
            us.editarUser(edituser);
            return RedirectToAction("ListaDeUsers");
        }

        public IActionResult RegistrarUser()
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaLoginAdmin(this);
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarUser(Usuario novoUser)
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaLoginAdmin(this);

            novoUser.Senha = Criptografacao.TextCrip(novoUser.Senha);

            UsuarioService us = new UsuarioService();
            us.adicionarUsuario(novoUser);

            return RedirectToAction("CadastroRealizado");
        }


        public IActionResult ExcluirUser(int id)
        {
            return View(new UsuarioService().Listar(id));
        }

        [HttpPost]
        public IActionResult ExcluirUser(string decisao, int id)
        {
            if (decisao=="Excluir")
            {
                ViewData["Mensagem"] = "Exclusão do usuario" +new UsuarioService().Listar(id).Nome+"Realizada com sucesso";
                new UsuarioService().excluirUser(id);
                return View("ListaDeUsers", new UsuarioService().Listar());
            }else
            {
                ViewData["Mensagem"] = "Exclusão cancelada";
                return View("ListaDeUsers", new UsuarioService().Listar());
            }
        }


        public IActionResult cadastroRealizado()
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaLoginAdmin(this);

            return View();
        }

        public IActionResult NeedAdmin()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }

        public IActionResult Sair()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}