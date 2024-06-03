namespace BackEnd.Models.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity(int Id)
        {
            this.Id = Id;
        }
        protected BaseEntity()
        {
            
        }
        public int Id { get; set; }
    }
}
