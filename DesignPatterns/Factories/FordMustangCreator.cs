using DesignPatterns.ModelBuilders; // Importa el espacio de nombres que probablemente incluye 'CarBuilder'.
using DesignPatterns.Models; // Importa el espacio de nombres que contiene 'Vehicle'.

namespace DesignPatterns.Factories // Define un espacio de nombres para las fábricas, agrupando clases relacionadas con la creación de objetos.
{
    // 'FordMustangCreator' es una clase concreta que hereda de 'Creator'.
    // Esta clase se enfoca en la creación de un tipo específico de vehículo, presumiblemente un Ford Mustang.
    public class FordMustangCreator : Creator
    {
        // Implementación concreta del método 'Create' de la clase abstracta 'Creator'.
        public override Vehicle Create()
        {
            // Crea una nueva instancia de 'CarBuilder', una clase que sigue el patrón 'Builder'.
            var builder = new CarBuilder();

            // Aquí, a diferencia de los ejemplos anteriores, no se especifican detalles como el modelo o el color.
            // Se utiliza el 'CarBuilder' para construir un vehículo, pero los detalles específicos no están definidos en este método.
            return builder
                // Finaliza la construcción del objeto 'Vehicle' y lo devuelve.
                // El objeto devuelto es un 'Vehicle' construido con los valores predeterminados del 'CarBuilder'.
                .Build();
        }
    }
}
