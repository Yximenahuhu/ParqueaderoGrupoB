using System.Collections.Generic; //Librería donde se encuentra definida la interface
using System.Linq;
using ParqueaderoGrupoB.App.Dominio;


namespace ParqueaderoGrupoB.App.Persistencia
{
    public class RepositorioVehiculo : IRepositorioVehiculo
    {
        private readonly AppContext _appContext;
        public RepositorioVehiculo (AppContext appContext)
        {
            _appContext=appContext;
        }
        Vehiculo IRepositorioVehiculo.addVehiculo(Vehiculo vehiculo)
        {
            var vehiculoAdicionado=_appContext.Vehiculos.Add(vehiculo);
            _appContext.SaveChanges();
            return vehiculoAdicionado.Entity;            
        }

        Vehiculo IRepositorioVehiculo.editVehiculo(Vehiculo vehiculo)
        {
            var vehiculoEncontrado=_appContext.Vehiculos.FirstOrDefault(p => p.Placa == vehiculo.Placa);
            if(vehiculoEncontrado !=null)
            {
                vehiculoEncontrado.Id = vehiculo.Id;
                vehiculoEncontrado.Nombre = vehiculo.Nombre;
                vehiculoEncontrado.Direccion = vehiculo.Direccion;
                vehiculoEncontrado.Telefono = vehiculo.Telefono;
                vehiculoEncontrado.TipoVehiculo = vehiculo.TipoVehiculo;
                vehiculoEncontrado.Tamaño =vehiculo.Tamaño;
                vehiculoEncontrado.Marca = vehiculo.Marca;
                vehiculoEncontrado.Color = vehiculo.Color;
                vehiculoEncontrado.Modelo = vehiculo.Modelo;
                
                
                _appContext.SaveChanges();
            }
            return vehiculoEncontrado;
        }

        IEnumerable<Vehiculo> IRepositorioVehiculo.getAllVehiculos()
        {
            return _appContext.Vehiculos;
        }

        Vehiculo IRepositorioVehiculo.getVehiculo(string placaVehiculo)
        {
            return _appContext.Vehiculos.FirstOrDefault(p => p.Placa == placaVehiculo);
        }

        void IRepositorioVehiculo.removeVehiculo(string placaVehiculo)
        {
            var VehiculoEncontrado=_appContext.Vehiculos.FirstOrDefault(p => p.Placa == placaVehiculo);
            if (VehiculoEncontrado ==null)
                return;
            _appContext.Vehiculos.Remove(VehiculoEncontrado);
            _appContext.SaveChanges();

        }
    }
}