using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaOnLine.Domain.Models;

namespace VentaOnLine.Domain.Repositories
{
    public interface ICategoriaRepository
    {

        Task<int> Agregar(Categoria entidad);

        Task<bool> Modificar(Categoria entidad);

        Task<Categoria> Eliminar(int id);

        Task<Categoria> Obtener(int id);

        Task<List<Categoria>> Obtener(string nombre);

    }
}
