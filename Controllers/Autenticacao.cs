using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Biblioteca.Models;
using System.Linq;
using System.Collections.Generic;


namespace Biblioteca.Controllers
{
    public class Autenticacao
    {
        public static void CheckLogin(Controller controller)
        {   
            if(string.IsNullOrEmpty(controller.HttpContext.Session.GetString("Login")))
            {
                controller.Request.HttpContext.Response.Redirect("/Home/Login");
            }
        }

        public static bool verificSenhaLogin(string Login, string Senha, Controller controller)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                verificaAdmin(bc);

                Senha = Criptografacao.TextCrip(Senha);

                IQueryable<Usuario> UserEncontrado = bc.Usuario.Where(u => u.Login==Login && u.Senha==Senha);
                List<Usuario>ListUserEncontrado = UserEncontrado.ToList();

                if (ListUserEncontrado.Count == 0)
                {
                    return false;
                }
                else
                {
                    controller.HttpContext.Session.SetString("Login", ListUserEncontrado[0].Login);
                    controller.HttpContext.Session.SetString("Nome", ListUserEncontrado[0].Nome);
                    controller.HttpContext.Session.SetInt32("Tipo", ListUserEncontrado[0].Tipo);
                    return true;
                }
            }
        }

        public static void verificaAdmin(BibliotecaContext bc)
        {
            IQueryable<Usuario> adminEncontrado = bc.Usuario.Where(u => u.Login == "admin");
            if (adminEncontrado.ToList().Count == 0)
            {
                Usuario admin = new Usuario();
                admin.Login = "admin";
                admin.Senha = Criptografacao.TextCrip("admin");
                admin.Tipo = Usuario.ADMIN;
                admin.Nome =  "Administrador";

                bc.Usuario.Add(admin);
                bc.SaveChanges();
            }
        }

        public static void verificaLoginAdmin(Controller controller)
        {
            if (!(controller.HttpContext.Session.GetInt32("Tipo")==Usuario.ADMIN))
            {
                controller.Request.HttpContext.Response.Redirect("/Usuario/NeedAdmin");
            }
        }

    }
}