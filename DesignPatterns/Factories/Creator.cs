using DesignPatterns.Models;
namespace DesignPatterns.Factories
{
    //Extraer funcionalidad de crear
    public abstract class Creator
    {
        public abstract Vehicle Create();
    }
}
