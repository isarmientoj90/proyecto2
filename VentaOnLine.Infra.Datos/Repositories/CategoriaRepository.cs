using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaOnLine.Domain.Models;
using VentaOnLine.Domain.Repositories;

namespace VentaOnLine.Infra.Datos.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        public Task<int> Agregar(Categoria entidad)
        {
            throw new NotImplementedException();
        }

        public Task<Categoria> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Modificar(Categoria entidad)
        {
            throw new NotImplementedException();
        }

        public Task<Categoria> Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Categoria>> Obtener(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
