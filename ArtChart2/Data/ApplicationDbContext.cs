using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ArtChart2.Models;

namespace ArtChart2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ArtChart2.Models.Artwork> Artwork { get; set; }
        public DbSet<ArtChart2.Models.Artist> Artist { get; set; }
        public DbSet<ArtChart2.Models.ArtType> ArtType { get; set; }
    }
}
