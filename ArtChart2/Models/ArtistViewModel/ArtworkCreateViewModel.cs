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
        private ApplicationDbContext _context;

        public ArtworkCreateViewModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Artwork Artwork { get; set; }


    }
}