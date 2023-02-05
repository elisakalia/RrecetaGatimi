using System;
using System.Runtime.ConstrainedExecution;
using Microsoft.EntityFrameworkCore;
using RrecetaGatimi.Data.Model;

namespace RrecetaGatimi.Data
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("DataSource=Main.db");
        public DbSet<Receta> Receta { get; set; }
    }
}

