using JobTindProyecto.Data;
using JobTindProyecto.Dominio;
using JobTindProyecto.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTindProyecto.Repositorio
{
    public class AnuncioRepositorio : IAnuncio
    {
        private ApplicationDbContext bd;

        public AnuncioRepositorio(ApplicationDbContext bd)
        {
            this.bd = bd;
        }


        public void Delete(Anuncio a)
        {
            bd.Anuncio.Remove(a);
        }


        public void Find(Anuncio a)
        {
            bd.Anuncio.Find(a);
        }

        public ICollection<Anuncio> ListarAnuncios()
        {
            return bd.Anuncio.ToList();
        }


        public void Save(Anuncio a)
        {
            bd.Anuncio.Add(a);
            bd.SaveChanges();
        }

    }
}

