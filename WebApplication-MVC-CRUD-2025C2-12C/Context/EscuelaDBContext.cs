using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_MVC_CRUD_2025C2_12C.Models;
using System.Collections.Generic;

namespace WebApplication_MVC_CRUD_2025C2_12C.Context
{
    public class EscuelaDBContext : DbContext
    {
        public EscuelaDBContext(DbContextOptions<EscuelaDBContext> options) : base(options)
        {
        }
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
