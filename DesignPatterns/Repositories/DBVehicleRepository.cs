using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Repositories
{
    // 'DBVehicleRepository' es una clase que implementa la interfaz 'IVehicleRepository'.
    // Está destinada a interactuar con una base de datos para realizar operaciones relacionadas con los objetos 'Vehicle'.
    public class DBVehicleRepository : IVehicleRepository
    {
        // Método para agregar un nuevo vehículo a la base de datos.
        public void AddVehicle(Vehicle vehicle)
        {
            // Actualmente, la implementación lanza 'NotImplementedException' para indicar que la funcionalidad aún no está disponible.
            throw new NotImplementedException();
        }

        // Método para encontrar un vehículo por su ID en la base de datos.
        public Vehicle Find(string id)
        {
            // Actualmente, la implementación lanza 'NotImplementedException' para indicar que la funcionalidad aún no está disponible.
            throw new NotImplementedException();
        }

        // Método para obtener una colección de todos los vehículos de la base de datos.
        public ICollection<Vehicle> GetVehicles()
        {
            // Actualmente, la implementación lanza 'NotImplementedException' para indicar que la funcionalidad aún no está disponible.
            throw new NotImplementedException();
        }
    }
}

