using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SitInMonitoring.Models;

namespace SitInMonitoring.Data
{
    public class SitInMonitoringContext : DbContext
    {
        public SitInMonitoringContext (DbContextOptions<SitInMonitoringContext> options)
            : base(options)
        {
        }

        public DbSet<SitInMonitoring.Models.Users> Users { get; set; } = default!;
    }
}
