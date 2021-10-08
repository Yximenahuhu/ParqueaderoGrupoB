using System.Collections.Generic;
using System.Linq;
using ParqueaderoGrupoB.App.Dominio;

namespace ParqueaderoGrupoB.App.Persistencia
{
    public class RepositorioPersona : IRepositorioPersona()
    {
        private readonly AppContext _appContext;

        public RepositorioPPersona(AppContext appContext)
        {
            _appContext = appContext;
        }

        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
            var personaAdicionado = _appContext.Persona.Add(persona);
            _appContext.SaveChanges();
            return personaAdicionado.Entity;
        }

        void IRepositorioPersona.DeletePersona(int idPersona)
        {
            var personaEncontrado = _appContext.Persona.FirstOrDefault(p => p.Id == idPersona);
            if (personaEncontrado == null) 
                return;
            _appContext.Persona.Remove(personaEncontrado);
            _appContext.SaveChanges();           
        }

        IEnumerable<Persona> IRepositorioPersona.GetAllPersona()
        {
            return _appContext.Persona;
        }

        Persona IRepositorioPersona.GetPersona(int idPersona)
        {
            return _appContext.Persona.FirstOrDefault(p => p.Id == idPersona);
        }     
        
        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
            var personaEncontrado = _appContext.Persona.FirstOrDefault(p => p.Id == persona.Id);
            if (personaEncontrado!=null)
            {
                personaEncontrado.Nombre = persona.Nombre;
                personaEncontrado.Telefono=persona.NumeroTelefono;
                personaEncontrado.Direccion=persona.Direccion;
                personaEncontrado.FechaNacimiento=persona.FechaNacimiento;
                   
                _appContext.SaveChanges();
            }
            
            return personaEncontrado;
        }

    }
}
