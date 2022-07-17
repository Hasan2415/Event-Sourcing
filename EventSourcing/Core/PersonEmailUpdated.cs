namespace Core
{
    public class PersonEmailUpdated : IEvent
    {
        public string? Email { get; set; }
    }
}