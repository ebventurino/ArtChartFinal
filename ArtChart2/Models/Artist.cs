using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ArtChart2.Models
{
    public class Artist : IdentityUser

    {
        //public Artist() { }

        //[Required]

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        //[Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        //[Required]
        public string StreetAddress { get; set; }

        public virtual ICollection<Artwork> Artworks { get; set; }

    }
}
