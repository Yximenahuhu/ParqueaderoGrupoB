using System;
using System.Collections.Generic;
using System.Linq;
using ParqueaderoGrupoB.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace ParqueaderoGrupoB.app.Persistencia{

    public class RepositorioVehiculo : IRepositorioVehiculo
    {
        private readonly AppContext _appContext;
        public RepositorioVehiculo(AppContext appContext)
        {
            _appContext=appContext;
        }
           

        public Vehiculo addVehiculo(Vehiculo vehiculo)
        {
            var VehiculoAdd=_appContext.Vehiculos.Add(vehiculo);
            _appContext.SaveChanges();
            return VehiculoAdd;
        }

        public Vehiculo editVehiculo(Vehiculo vehiculo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vehiculo> getAllVehiculos()
        {
            throw new NotImplementedException();
        }

        public Vehiculo getVehiculo(int id)
        {
            throw new NotImplementedException();
        }

        public void removeVehiculo(int id)
        {
            throw new NotImplementedException();
        }
    }


