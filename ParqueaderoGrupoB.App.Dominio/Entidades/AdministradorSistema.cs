using System;
namespace ParqueaderoGrupoB.App.Dominio
{

    public class AdministradorSistema:Persona
    {
        public Gerente CrearGerente {get; set; }
        public Auxiliar CrearAuxiliar {get; set; }
        
    }
}