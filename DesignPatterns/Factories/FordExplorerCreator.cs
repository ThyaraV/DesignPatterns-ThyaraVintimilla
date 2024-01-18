using DesignPatterns.ModelBuilders; // Importa el espacio de nombres que probablemente incluye 'CarBuilder'.
using DesignPatterns.Models; // Importa el espacio de nombres que contiene 'Vehicle'.

namespace DesignPatterns.Factories // Define un espacio de nombres para las fábricas, agrupando clases relacionadas con la creación de objetos.
{
    // 'FordExplorerCreator' es una clase concreta que extiende 'Creator'.
    // Proporciona una implementación específica del método 'Create' para crear un tipo de vehículo, en este caso, un Ford Explorer.
    public class FordExplorerCreator : Creator
    {
        // Implementación del método 'Create' definido en la clase abstracta 'Creator'.
        public override Vehicle Create()
        {
            // Crea una nueva instancia de 'CarBuilder', una clase que sigue el patrón 'Builder'
            // para construir objetos complejos de manera simplificada y paso a paso.
            var builder = new CarBuilder();

            // Utiliza el 'CarBuilder' para configurar un vehículo específico.
            // Aquí, configura el modelo del vehículo como 'Explorer' y el color como 'Negro'.
            return builder
                .SetModel("Explorer")
                .SetColor("Black")
                // Finaliza la construcción del objeto 'Vehicle' y lo devuelve.
                .Build();
        }
    }
}
