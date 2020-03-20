using MicroRabbit.Domain.Core.Events;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler
    {
        Task Handle<T>(T Event) where T : Event;
    }

    public interface IEventHandler
    {

    }
}
