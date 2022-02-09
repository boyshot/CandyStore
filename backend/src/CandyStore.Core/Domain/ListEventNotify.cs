using CandyStore.Core.Messages;
using System.Collections.Generic;

namespace CandyStore.Core.Domain
{
    public class ListEventNotify
    {
        private List<Event> _listNotify { get; set; } = new List<Event>();

        public void AddEvent(Event evento)
        {
            _listNotify.Add(evento);
        }

        public void DeleteEvent(Event eventItem)
        {
            _listNotify.Remove(eventItem);
        }

        public void ClearEvent()
        {
            _listNotify.Clear();
        }

        public IReadOnlyCollection<Event> ListReadNotify => _listNotify.AsReadOnly();
    }
}
