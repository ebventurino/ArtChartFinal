using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArtChart2.Models
{
    public class Artwork
    {
        [Key]
        public int ArtworkId { get; set; }

        [Required]
        [StringLength(55)]
        public string Title { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Price { get; set; }

        [Required]
        public string Medium { get; set; }

        [Required]
        [Display(Name = "Product Category")]
        public int ArtTypeId { get; set; }

        [Required]
        public Artist Artist { get; set; }
    }
}
