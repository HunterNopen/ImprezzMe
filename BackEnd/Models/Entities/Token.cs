namespace BackEnd.Models.Entities
{
    public class Token : BaseEntity
    {
        public string Value { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
