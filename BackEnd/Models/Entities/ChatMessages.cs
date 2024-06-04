namespace BackEnd.Models.Entities
{
    public class ChatMessages : BaseEntity
    {
        public string Message { get; set; }
        public DateTime Date { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int ChatId { get; set; }
        public Chat Chat { get; set; }
    }
}
