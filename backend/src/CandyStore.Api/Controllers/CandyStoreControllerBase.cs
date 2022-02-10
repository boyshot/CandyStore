using CandyStore.Core.Communication.Mediator;
using CandyStore.Core.Messages.CommonMessages.Notifications;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CandyStore.Api.Controllers
{
    public class CandyStoreControllerBase : ControllerBase
    {
        private readonly DomainNotificationHandler _notifications;
        private readonly IMediatorHandler _mediatorHandler;

        protected Guid ClienteId = Guid.Parse("4885e451-b0e4-4490-b959-04fabc806d32");

        protected CandyStoreControllerBase(INotificationHandler<DomainNotification> notifications,
                                           IMediatorHandler mediatorHandler)
        {
            _notifications = (DomainNotificationHandler)notifications;
            _mediatorHandler = mediatorHandler;
        }

        protected bool IsValidOperation()
        {
            return !_notifications.ExistNotify();
        }

        protected IEnumerable<string> GetListNotifyError()
        {
            return _notifications.GetListNotify().Select(c => c.Value).ToList();
        }

        protected void NotifyError(string code, string message)
        {
            _mediatorHandler.PublishNotify(new DomainNotification(code, message));
        }
    }
}
