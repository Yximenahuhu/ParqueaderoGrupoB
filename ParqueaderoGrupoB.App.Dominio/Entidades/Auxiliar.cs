using System;
namespace ParqueaderoGrupoB.App.Dominio
{

    public class Auxiliar:Persona
    {
        public Cliente CrearCliente {get; set; }
        public Vehiculo CrearVehiculo {get; set; }
        public Reserva CrearReserva {get; set; }
    }
}