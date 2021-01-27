namespace Data.Entities
{
    public class Photo : Entity
    {
        public string PhotoTitle { get; set; }
        public string PhotoDescription { get; set; }
        public string PhotoPath { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
