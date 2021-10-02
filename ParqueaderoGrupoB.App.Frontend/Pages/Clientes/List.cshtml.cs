using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ParqueaderoGrupoB.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
        private string[] datos_clientes = {"Id:","Nombre:","Telefono:","Direccion:","Tipo Vehiculo:","Cantidad Vehiculos:"};

public List<string> ListaClientes { get; set; }
        public void OnGet()
        {
            ListaClientes = new List<string>();
            ListaClientes.AddRange(datos_clientes);
        }
    }
}
