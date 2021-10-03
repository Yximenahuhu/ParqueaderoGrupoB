using System;
namespace ParqueaderoGrupoB.App.Dominio
{

    public class Vehiculo:Persona
    {
        public string Placa {get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Tamaño { get; set; }
        public string TipoVehiculo { get; set; }
    }
}