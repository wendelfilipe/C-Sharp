using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace C_
{
    public class AppDbContext : DbContext
    {

        public DbSet<Setores> Setores { get; set; }

        public DbSet<Funcionarios> Funcionarios { get; set; }
        
        
        
        
    }
}