using Newtonsoft.Json;

namespace Core
{
    public class EventDataRepository
    {
        private List<EventData> _events = new List<EventData>();

        public EventDataRepository()
        {
            _events.Add(new EventData
            {
                Id = 1,
                EntityId = 1,
                EntityType = nameof(Person),
                EventType = nameof(PersonCreated),
                EventSerializedData = JsonConvert
                .SerializeObject(new PersonCreated
                {
                    Id = 1,
                    FirstName = "Hasan",
                    LastName = "Rezaei",
                    Email = "Hasan@gmail.com",
                    Mobile = "8523694",
                })
            });
            _events.Add(new EventData
            {
                Id = 1,
                EntityId = 1,
                EntityType = nameof(Person),
                EventType = nameof(PersonEmailUpdated),
                EventSerializedData = JsonConvert
                .SerializeObject(new PersonEmailUpdated
                {
                    Email = "hasanRezaei@gmail.com"
                })
            });
            _events.Add(new EventData
            {
                Id = 1,
                EntityId = 1,
                EntityType = nameof(Person),
                EventType = nameof(PersonMobileUpdated),
                EventSerializedData = JsonConvert
                .SerializeObject(new PersonMobileUpdated
                {
                    Mobile = "987654321"
                })
            });
            _events.Add(new EventData
            {
                Id = 1,
                EntityId = 2,
                EntityType = nameof(Person),
                EventType = nameof(PersonCreated),
                EventSerializedData = JsonConvert
                .SerializeObject(new PersonCreated
                {
                    Id = 2,
                    FirstName = "Mohammad",
                    LastName = "Asghari",
                    Email = "Mohammad@gmail.com",
                    Mobile = "852369",
                })
            });
        }

        public List<EventData> GetAllByEntityId(int entityId, string entityType)
        {
            return _events
                .Where(_ => _.EntityId == entityId && 
                _.EntityType == entityType)
                .ToList();
        }
    }
}