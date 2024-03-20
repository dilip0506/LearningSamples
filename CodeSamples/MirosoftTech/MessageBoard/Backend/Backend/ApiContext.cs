using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Backend
{
    public class ApiContext:DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options): base(options) {}
        public DbSet<Models.Messages> Messages { get; set; }
        public DbSet<Models.User> Users { get; set; }
    }
}
