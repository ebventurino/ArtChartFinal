using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArtChart2.Models
{
    public class ArtType
    {
        [Key]
        public int ArtTypeId { get; set; }

        [Required]
        [StringLength(55)]
        public string Category { get; set; }

    }
}
