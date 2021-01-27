namespace Data.Entities
{
    public class Following : Entity
    {
        public int UserId { get; set; }
        public int FollowedId { get; set; }
        public virtual User User { get; set; }
        public virtual User Followed { get; set; }
    }
}
