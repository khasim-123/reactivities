using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Activity> Activities { get; set; }
        
    }
}