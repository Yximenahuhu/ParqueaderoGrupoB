using System.Collections.Generic;
using System.Linq;
using ParqueaderoGrupoB.App.Dominio;

namespace ParqueaderoGrupoB.App.Persistencia
{
    public class RepositorioAdministrador_Sistema : IRepositorioAdministrador_Sistema
    {
        private readonly Contexto _contexto;
        private Security security;

        public RepositorioAdministrador_Sistema(Contexto contexto){
            _contexto = contexto;
            security = new Security();
        }
        public Administrador_Sistema addAdministrador_Sistema(Administrador_Sistema Administrador_Sistema)
        {
            Administrador_Sistema.password = security.GetMD5Hash(Administrador_Sistema.password);
            Administrador_Sistema newAdministrador_Sistema = _contexto.Add(Administrador_Sistema).Entity;
            _contexto.SaveChanges();
            return newAdministrador_Sistema;
        }

        public Administrador_Sistema editAdministrador_Sistema(Administrador_Sistema Administrador_Sistema)
        {
            Administrador_Sistema.password = security.GetMD5Hash(Administrador_Sistema.password);
            Administrador_Sistema Administrador_SistemaEncontrado = _contexto.Administrador_Sistemas.FirstOrDefault(m => g.cedula == Administrador_Sistema.cedula);
            if(Administrador_Sistema != null){
                Administrador_SistemaEncontrado.cedula = Administrador_Sistema.cedula;
                Administrador_SistemaEncontrado.nombre = Administrador_Sistema.nombre;
                Administrador_SistemaEncontrado.username = Administrador_Sistema.username;
                Administrador_SistemaEncontrado.password = Administrador_Sistema.password;
                Administrador_SistemaEncontrado.email = Administrador_Sistema.email;

                _contexto.SaveChanges();
            }
            return Administrador_SistemaEncontrado;
        }

        public IEnumerable<Administrador_Sistema> getAllAdministrador_Sistemas()
        {
            return _contexto.Administrador_Sistemas;
        }

        public Administrador_Sistema getAdministrador_Sistema(int cedula)
        {
            Administrador_Sistema Administrador_Sistema = _contexto.Administrador_Sistemas.FirstOrDefault(m => m.cedula == cedula);
            return Administrador_Sistema;
        }

        public void removeAdministrador_Sistema(int cedula)
        {
            Administrador_Sistema Administrador_Sistema = _contexto.Administrador_Sistemas.FirstOrDefault(m => m.cedula == cedula);
            if (Administrador_Sistema != null){
                _contexto.Administrador_Sistemas.Remove(Administrador_Sistema);
                _contexto.SaveChanges();
            }
        }
    }
}

