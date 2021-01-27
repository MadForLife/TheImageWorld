using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Data.Entities
{
    public class User : IdentityUser<int>
    {
        private DateTime? timeStamp = null;
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Bio { get; set; }
        public string ProfilePicturePath { get; set; }
        public DateTime? TimeStamp
        {
            get { return this.timeStamp.HasValue ? this.timeStamp.Value : DateTime.Now; }
            set { this.timeStamp = value; }
        }
        public virtual ICollection<Photo> Photos { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Following> Followings { get; set; }
    }
}
