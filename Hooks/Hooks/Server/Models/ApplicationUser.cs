using Microsoft.AspNetCore.Identity;
using System.Drawing;

namespace Hooks.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public byte[]? ProfilePhoto { get; set; }

        /*
        public string Bio {  get; set; }
        public int Height {  get; set; }
        public string Ethnicity { get; set; }
        public Boolean Smoking { get; set; }
        public Boolean Drinking { get; set; }
        public string Religion { get; set; }
        */
    }
}