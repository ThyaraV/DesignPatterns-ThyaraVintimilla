using DesignPatterns.Models;
using System;

namespace DesignPatterns.ModelBuilders
{
    // 'MotocycleBuilder' es una clase que implementa la interfaz 'IBuilder<Motocycle>'.
    // Esta clase se utiliza para construir instancias del modelo 'Motocycle'.
    public class MotocycleBuilder : IBuilder<Motocycle>
    {
        // Campos predeterminados para una Motocicleta.
        // Se inicializan con valores por defecto para una motocicleta Ford RS200 de color negro del año actual.
        public string Brand = "Ford";
        public string Model = "RS200";
        public string Color = "Black";
        public int Year = DateTime.Now.Year;

        // Métodos 'Set' para cada propiedad que permiten configurar la motocicleta.
        // Cada método retorna 'this', permitiendo encadenar llamadas en un estilo 'fluent'.
        public MotocycleBuilder SetBrand(string brand)
        {
            Brand = brand;
            return this;
        }

        public MotocycleBuilder SetModel(string model)
        {
            Model = model;
            return this;
        }

        public MotocycleBuilder SetColor(string color)
        {
            Color = color;
            return this;
        }

        public MotocycleBuilder SetYear(int year)
        {
            Year = year;
            return this;
        }

        // El método 'Build' construye y devuelve una nueva instancia de 'Motocycle'
        // utilizando los valores actuales de las propiedades del 'MotocycleBuilder'.
        public Motocycle Build()
        {
            // Creación de la nueva instancia de 'Motocycle' con los valores configurados.
            return new Motocycle(Color, Brand, Model, Year);
        }
    }
}
