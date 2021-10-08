using System.Collections.Generic;
using System.Linq;
using ParqueaderoGrupoB.App.Dominio;

namespace ParqueaderoGrupoB.App.Persistencia
{
    public class RepositorioAuxiliar : IRepositorioAuxiliar
    {
        private readonly AppContext _appContext;

        public RepositorioPAuxiliar(AppContext appContext)
        {
            _appContext = appContext;
        }

        Auxiliar IRepositorioAuxiliar.AddAuxiliar(Auxiliar auxiliar)
        {
            var auxiliarAdicionado = _appContext.Auxiliar.Add(auxiliar);
            _appContext.SaveChanges();
            return auxiliarAdicionado.Entity;
        }

        void IRepositorioAuxiliar.DeleteAuxiliar(int idAuxiliar)
        {
            var auxiliarEncontrado = _appContext.Auxiliar.FirstOrDefault(p => p.Id == idAuxiliar);
            if (auxiliarEncontrado == null) 
                return;
            _appContext.Auxiliar.Remove(auxiliarEncontrado);
            _appContext.SaveChanges();           
        }

        IEnumerable<Auxiliar> IRepositorioAuxiliar.GetAllAuxiliar()
        {
            return _appContext.Auxiliar;
        }

        Auxiliar IRepositorioAuxiliar.GetAuxiliar(int idAuxiliar)
        {
            return _appContext.Auxiliar.FirstOrDefault(p => p.Id == idAuxiliar);
        }     
        
        Auxiliar IRepositorioAuxiliar.UpdateAuxiliar(Auxiliar auxiliar)
        {
            var auxiliarEncontrado = _appContext.Auxiliar.FirstOrDefault(p => p.Id == auxiliar.Id);
            if (auxiliarEncontrado!=null)
            {
                auxiliarEncontrado.Nombre = auxiliar.Nombre;
                auxiliarEncontrado.Telefono=auxiliar.NumeroTelefono;
                auxiliarEncontrado.Direccion=auxiliar.Direccion;
                auxiliarEncontrado.FechaNacimiento=auxiliar.FechaNacimiento;
                   
                _appContext.SaveChanges();
            }
            
            return auxiliarEncontrado;
        }

    }
}
