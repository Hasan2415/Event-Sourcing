namespace Core
{
    public abstract class BaseEntity
    {
        private List<IEvent> _events = new List<IEvent>();

        public List<IEvent> Events { get { return _events; } }

        protected void Add(IEvent @event)
        {
            _events.Add(@event);
        }
    }
}