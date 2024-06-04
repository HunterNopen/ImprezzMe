namespace BackEnd.Models.Entities
{
    public class Chat : BaseEntity
    {
        public string Link { get; set; } = "";

        public int EventId { get; set; }
        public Event Event { get; set; }

    }
}
