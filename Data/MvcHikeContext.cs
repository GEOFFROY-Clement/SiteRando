using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SiteRando.Models;

namespace SiteRando.Data
{
    public class MvcHikeContext : DbContext
    {
        public MvcHikeContext(DbContextOptions<MvcHikeContext> options) : base(options)
        {

        }

        public DbSet<Hike> Hikes
        {
            get;set;
        }
        
    }
}
