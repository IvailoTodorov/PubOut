namespace PubOut.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    public class User : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public string ProfilePucture { get; set; }
        public string CoverPicture { get; set; }
        public string Description { get; set; }
        public string GitHubURL { get; set; }
        public string LinkedInURL { get; set; }
        public string TwitterURL { get; set; }
        public string FacebookURL { get; set; }
        public string TwitchURL { get; set; }
        public string Location { get; set; }
        public string Work { get; set; }
        public string Education { get; set; }
        public string Interests { get; set; }
        public string Languages { get; set; }

    }
}
