using System;
namespace ParqueaderoGrupoB.App.Dominio
{

    public class Cliente:Persona
    {
        public TipoVehiculo TipoVehiculo { get; set; }
        public int CantidadVehiculos {get; set; }
    }
}