using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GithudProj.Models;

namespace GithudProj.Data
{
    public class GithudProjContext : DbContext
    {
        public GithudProjContext (DbContextOptions<GithudProjContext> options)
            : base(options)
        {
        }

        public DbSet<GithudProj.Models.Employee> Employee { get; set; }
    }
}
