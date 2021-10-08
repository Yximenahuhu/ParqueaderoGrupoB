using System.Collections.Generic;
using ParqueaderoGrupoB.App.Dominio;

namespace ParqueaderoGrupoB.App.Persistencia
{
    public interface IRepositorioAuxiliar
    {
        IEnumerable<Auxiliar> GetAllAuxiliars();

        Auxiliar AddAuxiliar(Auxiliar auxiliar);

        Auxiliar UpdateAuxiliar(Auxiliar auxiliar);

        void DeleteAuxiliar(int idAuxiliar);

        Auxiliar GetAuxiliar(int idAuxiliar);
    }
}


