using System.Collections.Generic;
using ParqueaderoGrupoB.App.Dominio;

namespace ParqueaderoGrupoB.App.Persistencia
{
    public interface IRepositorioAdministrador_Sistema
    {
         IEnumerable<Administrador_Sistema> getAllAdministrador_Sistemas();
         Administrador_Sistema getAdministrador_Sistema(int cedula);
         Administrador_Sistema editAdministrador_Sistema(Administrador_Sistema Administrador_Sistema);
         void removeAdministrador_Sistema(int cedula);
         Administrador_Sistema addAdministrador_Sistema(Administrador_Sistema Administrador_Sistema);

    }
}


