using JobTindProyecto.Data;
using JobTindProyecto.Dominio;
using JobTindProyecto.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTindProyecto.Repositorio
{
    public class EmpresaRepositorio : IEmpresa
    {
        private ApplicationDbContext bd;

        public EmpresaRepositorio(ApplicationDbContext bd)
        {
            this.bd = bd;
        }
        public void Buscar(Empresa E)
        {
            bd.Empresas.Find(E);
        }

        public void Delete(Empresa E)
        {
            bd.Empresas.Remove(E);
        }

        public void Guardar(Empresa E)
        {

            bd.Empresas.Add(E);
            bd.SaveChanges();
        }

        public ICollection<Empresa> ListarEmpresas()
        {
            return bd.Empresas.ToList();
        }
    }
}
