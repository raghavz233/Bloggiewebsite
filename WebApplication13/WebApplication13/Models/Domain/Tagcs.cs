using System;

namespace WebApplication13.Models.Domain
{
    public class Tagcs
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string DisplayName { get; set; }

        public ICollection<BlogPost> Tags { get; set; }
    }
}
