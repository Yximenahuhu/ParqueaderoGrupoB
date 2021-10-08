using System.Collections.Generic;
using System.Linq;
using ParqueaderoGrupoB.App.Dominio;

namespace ParqueaderoGrupoB.App.Persistencia
{
    public class RepositorioGerente : IRepositorioGerente
    {
        private readonly Contexto _contexto;
        private Security security;

        public RepositorioGerente(Contexto contexto){
            _contexto = contexto;
            security = new Security();
        }
        public Gerente addGerente(Gerente gerente)
        {
            gerente.password = security.GetMD5Hash(gerente.password);
            Gerente newGerente = _contexto.Add(gerente).Entity;
            _contexto.SaveChanges();
            return newGerente;
        }

        public Gerente editGerente(Gerente gerente)
        {
            gerente.password = security.GetMD5Hash(gerente.password);
            Gerente gerenteEncontrado = _contexto.Gerentes.FirstOrDefault(m => g.cedula == gerente.cedula);
            if(gerente != null){
                gerenteEncontrado.cedula = gerente.cedula;
                gerenteEncontrado.nombre = gerente.nombre;
                gerenteEncontrado.username = gerente.username;
                gerenteEncontrado.password = gerente.password;
                gerenteEncontrado.email = gerente.email;

                _contexto.SaveChanges();
            }
            return gerenteEncontrado;
        }

        public IEnumerable<Gerente> getAllGerentes()
        {
            return _contexto.Gerentes;
        }

        public Gerente getGerente(int cedula)
        {
            Gerente gerente = _contexto.Gerentes.FirstOrDefault(m => m.cedula == cedula);
            return gerente;
        }

        public void removeGerente(int cedula)
        {
            Gerente gerente = _contexto.Gerentes.FirstOrDefault(m => m.cedula == cedula);
            if (gerente != null){
                _contexto.Gerentes.Remove(gerente);
                _contexto.SaveChanges();
            }
        }
    }
}