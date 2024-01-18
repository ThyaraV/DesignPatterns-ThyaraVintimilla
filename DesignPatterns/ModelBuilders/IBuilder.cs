using DesignPatterns.Models;

namespace DesignPatterns.ModelBuilders
{
    // 'IBuilder<T>' es una interfaz genérica.
    // Esta interfaz define un contrato para clases 'builder' que construyen objetos de tipo 'T'.
    public interface IBuilder<T>
    {
        // Método 'Build' que debe ser implementado por cualquier clase que implemente esta interfaz.
        // Este método es responsable de construir y devolver una instancia del tipo 'T'.
        T Build();
    }
}
