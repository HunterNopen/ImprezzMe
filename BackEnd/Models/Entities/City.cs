namespace BackEnd.Models.Entities
{
    public class City : BaseEntity
    {
        public string Name { get; set; }

        public IEnumerable<User> Users { get; set; }
    }
}
