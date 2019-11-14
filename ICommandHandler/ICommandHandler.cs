using System.Threading.Tasks;

namespace ICommandHandler
{
    public interface ICommandHandler<T>
    {
        Task HandleAsync(T command);
    }
}
