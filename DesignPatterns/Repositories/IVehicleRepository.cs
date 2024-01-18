using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Repositories
{
    // 'IVehicleRepository' es una interfaz que define un contrato para operaciones de repositorio de vehículos.
    public interface IVehicleRepository
    {
        // Método para obtener una colección de todos los vehículos.
        // Este método debería devolver todos los vehículos disponibles en el repositorio.
        ICollection<Vehicle> GetVehicles();

        // Método para agregar un nuevo vehículo al repositorio.
        // Este método toma un objeto 'Vehicle' y lo almacena en el repositorio.
        void AddVehicle(Vehicle vehicle);

        // Método para encontrar un vehículo específico por su ID.
        // Este método devuelve el vehículo correspondiente al ID proporcionado.
        Vehicle Find(string id);
    }
}
