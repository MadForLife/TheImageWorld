namespace Data.Entities
{
    public class Comment : Entity
    {
        public string Text { get; set; }
        public int UserId { get; set; }
        public int PhotoId { get; set; }
        public virtual User User { get; set; }
        public virtual Photo Photo { get; set; }
    }
}
