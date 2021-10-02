using System;
namespace ParqueaderoGrupoB.App.Dominio
{

    public class Reserva
    {
        public int Id { get; set; }
        public DateTime HoraIngreso { get; set; }
        public DateTime HoraSalida { get; set; }
        public Espacio Espacio { get; set; }
    }
}