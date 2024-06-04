namespace BackEnd.Models.Entities
{
    public class Event : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateStart { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }
    }
}
