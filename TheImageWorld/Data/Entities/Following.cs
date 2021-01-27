namespace Data.Entities
{
    public class Following : Entity
    {
        public int UserId { get; set; }
        public int FollowedId { get; set; }
        public User User { get; set; }
        public User Followed { get; set; }
    }
}
