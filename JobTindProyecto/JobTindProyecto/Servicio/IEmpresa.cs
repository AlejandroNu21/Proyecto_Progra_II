using JobTindProyecto.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTindProyecto.Servicio
{
  public  interface IEmpresa
    {
        void Guardar(Empresa E);

        void Delete(Empresa E);

        void Buscar(Empresa E);

        ICollection<Empresa> ListarEmpresas();
    }
}

