using System.Collections.Generic;
using ParqueaderoGrupoB.App.Dominio;

namespace ParqueaderoGrupoB.App.Persistencia
{
    public interface IRepositorioGerente
    {
         IEnumerable<Gerente> getAllGerentes();
         Gerente getGerente(int cedula);
         Gerente editGerente(Gerente gerente);
         void removeGerente(int cedula);
         Gerente addGerente(Gerente gerente);

    }
}

