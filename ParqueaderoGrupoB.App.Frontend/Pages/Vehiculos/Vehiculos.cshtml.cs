using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ParqueaderoGrupoB.App.Frontend.Pages
{
    public class VehiculosModel : PageModel
    {
        private string [] vehiculos = {"Numero placa:","Marca:","Modelo:","Color:","Tamaño:"};

        public List<string> ListaVehiculos { get; set; }

        public void OnGet()
        {
            ListaVehiculos = new List<string>();
            ListaVehiculos.AddRange(vehiculos);
        }
    }
}
