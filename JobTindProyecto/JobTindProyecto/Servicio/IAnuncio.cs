using JobTindProyecto.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTindProyecto.Servicio
{
   public interface IAnuncio
    {
        void Save(Anuncio a);

        void Delete(Anuncio a);

        void Find(Anuncio a);

        ICollection<Anuncio> ListarAnuncios();
    }
}
