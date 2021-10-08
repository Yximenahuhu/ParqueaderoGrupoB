using System.Collections.Generic;
using System.Linq;
using ParqueaderoGrupoB.App.Dominio;

namespace ParqueaderoGrupoB.App.Persistencia
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly Contexto _contexto;
        private Security security;

        public RepositorioCliente(Contexto contexto){
            _contexto = contexto;
            security = new Security();
        }
        public Cliente addCliente(Cliente cliente)
        {
            cliente.password = security.GetMD5Hash(cliente.password);
            Cliente newCliente = _contexto.Add(cliente).Entity;
            _contexto.SaveChanges();
            return newCliente;
        }

        public Cliente editCliente(Cliente cliente)
        {
            cliente.password = security.GetMD5Hash(cliente.password);
            Cliente clienteEncontrado = _contexto.Clientes.FirstOrDefault(m => g.cedula == cliente.cedula);
            if(cliente != null){
                clienteEncontrado.cedula = cliente.cedula;
                clienteEncontrado.nombre = cliente.nombre;
                clienteEncontrado.username = cliente.username;
                clienteEncontrado.password = cliente.password;
                clienteEncontrado.email = cliente.email;

                _contexto.SaveChanges();
            }
            return clienteEncontrado;
        }

        public IEnumerable<Cliente> getAllClientes()
        {
            return _contexto.Clientes;
        }

        public Cliente getCliente(int cedula)
        {
            Cliente cliente = _contexto.Clientes.FirstOrDefault(m => m.cedula == cedula);
            return cliente;
        }

        public void removeCliente(int cedula)
        {
            Cliente cliente = _contexto.Clientes.FirstOrDefault(m => m.cedula == cedula);
            if (cliente != null){
                _contexto.Clientes.Remove(cliente);
                _contexto.SaveChanges();
            }
        }
    }
}

