using DesignPatterns.Models; // Importa el espacio de nombres que contiene los modelos, presumiblemente incluyendo el tipo 'Vehicle'.

namespace DesignPatterns.Factories // Define un espacio de nombres para las fábricas, agrupando clases relacionadas con la creación de objetos.
{
    // La clase 'Creator' es una clase abstracta que define un 'factory method'.
    // Este método es abstracto, lo que significa que las clases derivadas deben implementar este método.
    public abstract class Creator
    {
        // 'Create' es un método abstracto que debe ser implementado por subclases de 'Creator'.
        // Este método se encarga de crear y retornar un objeto de tipo 'Vehicle'.
        // Al ser abstracto, no tiene implementación aquí, lo que permite a las subclases decidir cómo crear instancias de 'Vehicle'.
        public abstract Vehicle Create();
    }
}
