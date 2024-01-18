using System.Collections;
using DesignPatterns.Models;
using System.Collections.Generic;

namespace DesignPatterns.Infrastructure.Singletons
{
    // 'VehicleMemoryCollection' es una clase que implementa el patrón Singleton.
    // Se utiliza para mantener una única colección de vehículos en memoria.
    public class VehicleMemoryCollection
    {
        // Campo privado estático que mantiene la única instancia de la clase.
        private static VehicleMemoryCollection _instance;

        // Propiedad pública que expone la colección de vehículos.
        public ICollection<Vehicle> Vehicles { get; set; }

        // Constructor privado para prevenir la instanciación directa.
        // Inicializa la colección de vehículos.
        public VehicleMemoryCollection()
        {
            Vehicles = new List<Vehicle>();
        }

        // Propiedad estática 'Instance' que proporciona acceso a la única instancia de la clase.
        public static VehicleMemoryCollection Instance
        {
            get
            {
                // Si _instance es null, crea una nueva instancia de 'VehicleMemoryCollection'.
                if (_instance == null)
                {
                    _instance = new VehicleMemoryCollection();
                }
                // Devuelve la instancia existente.
                return _instance;
            }
        }
    }
}

