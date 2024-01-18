using DesignPatterns.ModelBuilders; // Importa el espacio de nombres que probablemente contiene el constructor de modelos 'CarBuilder'.
using DesignPatterns.Models; // Importa el espacio de nombres que contiene el modelo 'Vehicle'.

namespace DesignPatterns.Factories // Define un espacio de nombres para las fábricas, agrupando clases relacionadas con la creación de objetos.
{
    // 'FordEscapeCreator' es una clase concreta que hereda de 'Creator'.
    // Esta clase implementa la versión concreta del método 'Create' para crear un vehículo específico, en este caso, un 'Ford Escape'.
    public class FordEscapeCreator : Creator
    {
        // Implementación concreta del método 'Create' definido en la clase abstracta 'Creator'.
        public override Vehicle Create()
        {
            // Crea una instancia de 'CarBuilder', una clase que probablemente sigue el patrón 'Builder'
            // para facilitar la construcción de objetos complejos (en este caso, un vehículo).
            var builder = new CarBuilder();

            // Utiliza el constructor 'CarBuilder' para configurar específicamente un vehículo.
            // En este caso, configura el modelo como 'Escape' y el color como 'Rojo'.
            return builder
                .SetModel("Escape")
                .SetColor("Red")
                // Finaliza la construcción del vehículo y devuelve el resultado.
                .Build();
        }
    }
}

