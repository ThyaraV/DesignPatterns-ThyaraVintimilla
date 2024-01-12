using DesignPatterns.Models;
namespace DesignPatterns.ModelBuilders
{
    public interface IBuilder<T>
    {
        T Build();
    }
}
