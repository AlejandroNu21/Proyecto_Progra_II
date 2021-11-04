using JobTindProyecto.Data;
using JobTindProyecto.Dominio;
using JobTindProyecto.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTindProyecto.Repositorio
{
    public class UsuarioRepositorio : IUsuario
    {
        private ApplicationDbContext bd;

        public UsuarioRepositorio(ApplicationDbContext bd)
        {
            this.bd = bd;
        }

        public void Buscar(Usuario c)
        {
            bd.Usuarios.Find(c);
        }

        public void Delete(Usuario c)
        {
            bd.Usuarios.Remove(c);
        }

        public void Insertar(Usuario c)
        {
            bd.Usuarios.Add(c);
            bd.SaveChanges();
        }

        public ICollection<Usuario> ListarCursos()
        {
            return bd.Usuarios.ToList();
        }
    }
}
