using System.Collections.Generic;
using ParqueaderoGrupoB.App.Dominio;



namespace ParqueaderoGrupoB.App.Persistencia
{
    public interface IRepositorioVehiculo{
        IEnumerable<Vehiculo> getAllVehiculos();
        Vehiculo addVehiculo(Vehiculo vehiculo);
        Vehiculo editVehiculo(Vehiculo vehiculo);
        void removeVehiculo(string placaVehiculo);
        Vehiculo getVehiculo(string placaVehiculo);
    }

}