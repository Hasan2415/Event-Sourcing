namespace Core
{
    public class Person : BaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }

        public void LoadFromEvent(List<IEvent> events)
        {
            foreach (var e in events)
            {
                switch (e.GetType().Name)
                {
                    case nameof(PersonCreated) :
                        LoadCreation(e as PersonCreated);
                        break;
                    case nameof(PersonEmailUpdated):
                        LoadEmailChanged(e as PersonEmailUpdated);
                        break;
                    case nameof(PersonMobileUpdated):
                        LoadMobileChanged(e as PersonMobileUpdated);
                        break;
                }
            }
        }

        private void LoadCreation(PersonCreated personCreated)
        {
            Id = personCreated.Id;
            FirstName = personCreated.FirstName;
            LastName = personCreated.LastName;
            Email = personCreated.Email;
            Mobile = personCreated.Mobile;
        }

        private void LoadEmailChanged(PersonEmailUpdated personEmailUpdated)
        {
            Email = personEmailUpdated.Email;
        }

        private void LoadMobileChanged(PersonMobileUpdated personMobileUpdated)
        {
            Mobile = personMobileUpdated.Mobile;
        }
    }
}