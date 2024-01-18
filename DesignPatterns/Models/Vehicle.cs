using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Models;

namespace DesignPatterns.Models
{
    // 'Vehicle' es una clase abstracta que implementa la interfaz 'IVehicle'.
    public abstract class Vehicle : IVehicle
    {
        #region Private properties
        // Propiedad privada para mantener el estado del motor (encendido o apagado).
        private bool _isEngineOn { get; set; }
        #endregion

        #region Properties
        // ID único para cada vehículo, generado automáticamente.
        public readonly Guid ID;
        // Propiedades generales de un vehículo, como neumáticos, color, marca, modelo, etc.
        public virtual int Tires { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Gas { get; set; }
        public double FuelLimit { get; set; }
        public int Year {  get; set; }

        #endregion

        #region Constructors
        // Constructor de 'Vehicle' para inicializar propiedades básicas.
        public Vehicle(string color, string brand, string model,int year, double fuelLimit = 10)
        {
            ID = Guid.NewGuid();
            Color = color;
            Brand = brand;
            Model = model;
            FuelLimit = fuelLimit;
            Year = year;

        }

        #endregion

        #region Methods
        // Métodos para manejar el estado del vehículo, como añadir gasolina y manejar el motor.
        public void AddGas()
        {
            if(Gas <= FuelLimit)
            {
                Gas += 0.1;
            }
            else
            {
                throw new Exception("Gas Full");
            }
        }
        public void StartEngine()
        {
            if (_isEngineOn)
            {
                throw new Exception("Engine is already on");
            }
            if (NeedsGas())
            {
                throw new Exception("No enoguht gas. You need to go to Gas Station");
            }
            _isEngineOn = true;
        }

        public bool NeedsGas()
        {
            return !(Gas > 0);
        }

        public bool IsEngineOn()
        {
            return _isEngineOn;
        }

        public void StopEngine()
        {
            if (!_isEngineOn)
            {
                throw new Exception("Enigne already stopped");
            }

            _isEngineOn = false;
        }

        #endregion

    }
}
