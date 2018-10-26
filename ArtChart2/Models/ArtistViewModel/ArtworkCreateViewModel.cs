using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtChart2.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ArtChart2.Models.ArtistViewModel
{
    public class ArtworkCreateViewModel
    {

        public Artwork Artwork { get; set; }
        public List<ArtType> ArtTypes { get; set; }

        //    public ArtworkCreateViewModel(ApplicationDbContext context)
        //    {
        //        //ArtTypes = context.ArtType.Select(ArtType =>
        //        //new SelectListItem { Text = ArtType.Category, Value = ArtType.ArtTypeId }).ToList();
        //    }
        //}
    }
}