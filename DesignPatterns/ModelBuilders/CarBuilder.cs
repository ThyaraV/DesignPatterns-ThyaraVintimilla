using DesignPatterns.Models;
using System;

namespace DesignPatterns.ModelBuilders
{
    // 'CarBuilder' implementa la interfaz 'IBuilder<Car>'.
    // Esta clase se utiliza para construir instancias del modelo 'Car'.
    public class CarBuilder : IBuilder<Car>
    {
        // Campos predeterminados para un Carro.
        // Se inicializan con valores por defecto para un Ford Mustang rojo del año actual.
        public string Brand = "Ford";
        public string Model = "Mustang";
        public string Color = "Red";
        public int Year = DateTime.Now.Year;

        // Métodos 'Set' para cada propiedad que permiten configurar el carro.
        // Cada método retorna 'this', permitiendo encadenar llamadas en un estilo 'fluent'.
        public CarBuilder SetBrand(string brand)
        {
            Brand = brand;
            return this;
        }

        public CarBuilder SetModel(string model)
        {
            Model = model;
            return this;
        }

        public CarBuilder SetColor(string color)
        {
            Color = color;
            return this;
        }

        public CarBuilder SetYear(int year)
        {
            Year = year;
            return this;
        }

        // El método 'Build' construye y devuelve una nueva instancia de 'Car'
        // utilizando los valores actuales de las propiedades del 'CarBuilder'.
        public Car Build()
        {
            // Creación de la nueva instancia de 'Car' con los valores configurados.
            return new Car(Color, Brand, Model, Year);
        }
    }
}
