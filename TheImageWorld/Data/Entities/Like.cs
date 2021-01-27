namespace Data.Entities
{
    public class Like : Entity
    {
        public int UserId { get; set; }
        public int PhotoId { get; set; }
        public virtual User User { get; set; }
        public virtual Photo Photo { get; set; }
    }
}
