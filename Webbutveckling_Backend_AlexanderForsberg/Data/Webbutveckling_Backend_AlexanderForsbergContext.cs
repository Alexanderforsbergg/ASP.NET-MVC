#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Webbutveckling_Backend_AlexanderForsberg.Models;

namespace Webbutveckling_Backend_AlexanderForsberg.Data
{
    public class Webbutveckling_Backend_AlexanderForsbergContext : DbContext
    {
        public Webbutveckling_Backend_AlexanderForsbergContext (DbContextOptions<Webbutveckling_Backend_AlexanderForsbergContext> options)
            : base(options)
        {
        }

        public DbSet<Webbutveckling_Backend_AlexanderForsberg.Models.City> City { get; set; }
    }
}
