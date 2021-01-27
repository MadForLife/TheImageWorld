using System;

namespace Data.Entities
{
    public class Entity
    {
        private DateTime? timeStamp = null;
        public int Id { get; set; }
        public DateTime TimeStamp
        {
            get { return this.timeStamp.HasValue ? this.timeStamp.Value : DateTime.Now; }
            set { this.timeStamp = value; }
        }
    }
}
