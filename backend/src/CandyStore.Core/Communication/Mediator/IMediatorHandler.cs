using CandyStore.Core.Messages;
using CandyStore.Core.Messages.CommonMessages.DomainEvents;
using CandyStore.Core.Messages.CommonMessages.Notifications;
using System.Threading.Tasks;

namespace CandyStore.Core.Communication.Mediator
{
    public interface IMediatorHandler
    {
        Task<bool> SendCommand<T>(T command) where T : Command;
        Task PublishNotify<T>(T notify) where T : DomainNotification;
        Task PublishDomainEvent<T>(T domainEvent) where T : DomainEvent;
        Task PublishEvent<T>(T sendEvent) where T : Event;
    }
}
