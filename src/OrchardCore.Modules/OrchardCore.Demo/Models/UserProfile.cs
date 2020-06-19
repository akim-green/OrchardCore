using System;

namespace OrchardCore.Demo.Models
{
    public class UserProfile : ContentPart
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
