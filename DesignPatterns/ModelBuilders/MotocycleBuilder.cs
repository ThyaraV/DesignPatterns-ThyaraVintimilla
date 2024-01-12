using DesignPatterns.Models;
using System;

namespace DesignPatterns.ModelBuilders
{
    public class MotocycleBuilder:IBuilder<Motocycle>
    {
        public string Brand = "Ford";
        public string Model = "RS200";
        public string Color = "Black";
        public int Year = DateTime.Now.Year;

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

        public Motocycle Build()
        {
            return new Motocycle(Color, Brand, Model, Year);
        }

    }
}
