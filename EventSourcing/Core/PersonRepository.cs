using Newtonsoft.Json;

namespace Core
{
    public class PersonRepository
    {
        private readonly EventDataRepository _eventDataRepository;

        public PersonRepository()
        {
            _eventDataRepository = new EventDataRepository();
        }

        public Person Get(int personId)
        {
            var result = _eventDataRepository
                .GetAllByEntityId(personId, nameof(Person));
            var person = new Person();
            var events = new List<IEvent>();

            foreach (var item in result)
            {
                switch (item.EventType)
                {
                    case nameof(PersonCreated):
                        var personCreated = JsonConvert
                            .DeserializeObject<PersonCreated>
                            (item.EventSerializedData);
                        events.Add(personCreated);
                        break;
                    case nameof(PersonEmailUpdated):
                        var personEmailUpdated = JsonConvert
                            .DeserializeObject<PersonEmailUpdated>
                            (item.EventSerializedData);
                        events.Add(personEmailUpdated);
                        break;
                    case nameof(PersonMobileUpdated):
                        var personMobileUpdated = JsonConvert
                            .DeserializeObject<PersonMobileUpdated>
                            (item.EventSerializedData);
                        events.Add(personMobileUpdated);
                        break;
                }

            }
            person.LoadFromEvent(events);
            return person;
        }

        public Person Get(int personId,int version)
        {
            var result = _eventDataRepository
                .GetAllByEntityId(personId, nameof(Person));
            var temp = result.Take(version);
            var person = new Person();
            var events = new List<IEvent>();

            foreach (var item in temp)
            {
                switch (item.EventType)
                {
                    case nameof(PersonCreated):
                        var personCreated = JsonConvert
                            .DeserializeObject<PersonCreated>
                            (item.EventSerializedData);
                        events.Add(personCreated);
                        break;
                    case nameof(PersonEmailUpdated):
                        var personEmailUpdated = JsonConvert
                            .DeserializeObject<PersonEmailUpdated>
                            (item.EventSerializedData);
                        events.Add(personEmailUpdated);
                        break;
                    case nameof(PersonMobileUpdated):
                        var personMobileUpdated = JsonConvert
                            .DeserializeObject<PersonMobileUpdated>
                            (item.EventSerializedData);
                        events.Add(personMobileUpdated);
                        break;
                }

            }
            person.LoadFromEvent(events);
            return person;
        }
    }
}
