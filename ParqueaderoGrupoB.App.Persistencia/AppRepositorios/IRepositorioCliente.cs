using System.Collections.Generic;
using ParqueaderoGrupoB.App.Dominio;

namespace ParqueaderoGrupoB.App.Persistencia
{
    public interface IRepositorioCliente
    {
        IEnumerable<Cliente> GetAllClientes();

        Cliente AddCliente(Cliente cliente);

        Cliente UpdateCliente(Cliente cliente);

        void DeleteCliente(int idCliente);

        Cliente GetCliente(int idCliente);
    }
}


