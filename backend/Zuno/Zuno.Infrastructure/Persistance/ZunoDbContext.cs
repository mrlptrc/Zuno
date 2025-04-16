using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Zuno.Domain.Entitites;

namespace Zuno.Infrastructure.Persistance {
    public class ZunoDbContext : DbContext {
        public ZunoDbContext(DbContextOptions<ZunoDbContext> options) : base(options){ }
        public DbSet<User> Users { get; set; }
    }
}
