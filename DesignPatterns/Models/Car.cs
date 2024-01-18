using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    // 'Car' es una clase que extiende la clase 'Vehicle'.
    // Representa un tipo específico de vehículo, en este caso, un coche.
    public class Car : Vehicle
    {
        // Propiedad sobreescrita 'Tires' que siempre devuelve 4.
        // Esto refleja que un coche típicamente tiene 4 neumáticos.
        public override int Tires { get => 4; }

        // Constructor de 'Car' que llama al constructor de la clase base 'Vehicle'.
        // Inicializa un 'Car' con propiedades específicas como color, marca, modelo y año.
        public Car(string color, string brand, string model, int year) : base(color, brand, model, year)
        {
            // Aquí se podrían agregar inicializaciones o configuraciones adicionales específicas de 'Car'.
        }
    }
}
