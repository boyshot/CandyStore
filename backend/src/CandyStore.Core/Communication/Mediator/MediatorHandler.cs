using CandyStore.Core.Messages;
using CandyStore.Core.Messages.CommonMessages.DomainEvents;
using CandyStore.Core.Messages.CommonMessages.Notifications;
using MediatR;
using System.Threading.Tasks;

namespace CandyStore.Core.Communication.Mediator
{
    public class MediatorHandler : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public MediatorHandler(IMediator mediator) => _mediator = mediator;

        public async Task<bool> SendCommand<T>(T command) where T : Command
        {
            return await _mediator.Send(command);
        }

        public async Task PublishDomainEvent<T>(T domainEvent) where T : DomainEvent
        {
            await _mediator.Publish(domainEvent);
        }

        public async Task PublishEvent<T>(T publishEvent) where T : Event
        {
            await _mediator.Publish(publishEvent);
        }

        public async Task PublishNotify<T>(T domainNotify) where T : DomainNotification
        {
            await _mediator.Publish(domainNotify);
        }
    }
}
