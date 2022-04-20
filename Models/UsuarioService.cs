using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class UsuarioService
    {
        
        public List<Usuario> Listar()
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Usuario.ToList();
            }
        }


        public Usuario Listar(int id)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Usuario.Find(id);
            }
        }

        public void adicionarUsuario(Usuario nvUser)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Usuario.Add(nvUser);
                bc.SaveChanges();
            }
        }

        public void editarUser(Usuario edituser)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                Usuario u = bc.Usuario.Find(edituser.Id);

                u.Login = edituser.Login;
                u.Nome = edituser.Nome;
                u.Senha = edituser.Senha;
                u.Tipo = edituser.Tipo;

                bc.SaveChanges();
            }
        }

        public void excluirUser(int id)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Usuario.Remove(bc.Usuario.Find(id));
                bc.SaveChanges();
            }

        }

    }
}