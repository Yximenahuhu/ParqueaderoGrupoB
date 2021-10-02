using System.Collections.Generic;
using ParqueaderoGrupoB.App.Dominio;



namespace ParqueaderoGrupoB.app.Persistencia
{
    public interface IRepositorioVehiculo{
        IEnumerable<Vehiculo> getAllVehiculos();
        Vehiculo addVehiculo(Vehiculo vehiculo);
        Vehiculo editVehiculo(Vehiculo vehiculo);
        void removeVehiculo(int id);
        Vehiculo getVehiculo(int id);
    }

}