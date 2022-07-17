namespace Core
{
    public class EventData
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public string EntityType { get; set; }
        public string EventType { get; set; }
        public string EventSerializedData { get; set; }
    }
}