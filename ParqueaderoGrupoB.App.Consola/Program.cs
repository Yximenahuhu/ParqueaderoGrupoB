using System;
using ParqueaderoGrupoB.App.Dominio;
using ParqueaderoGrupoB.App.Persistencia;
namespace ParqueaderoGrupoB.App.Consola
{
    class Program
    {
        private static Persistencia.IRepositorioVehiculo _repoVehiculo= new RepositorioVehiculo(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Vamoj a Subir el primer carro");
            AddVehiculo();
            //BuscarVehiculo();
        }
        private static void AddVehiculo()
        {
            var vehiculo = new Vehiculo{
                Nombre = "Jonathan",
                Direccion = "Calle Falsa 123",
                Telefono = "313132152",
                Placa = "SYU130",
                TipoVehiculo = "Moto",
                Tamaño ="Compacto",
                Marca = "Renault",
                Color = "Negro",
                Modelo = "Twingo"
            };
            _repoVehiculo.addVehiculo(vehiculo);
        }
        private static void BuscarVehiculo(string placaVehiculo)
        {
            var vehiculo = _repoVehiculo.getVehiculo(placaVehiculo);
            Console.WriteLine(vehiculo.Nombre + " " + placaVehiculo);
        }
    }
}
