using System;
using Alisson.Models;
using Microsoft.EntityFrameworkCore;

namespace Alisson.Data;

public class AppDataContext : DbContext
{
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Folha> Folhas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=alisson.db");
    }   
}
