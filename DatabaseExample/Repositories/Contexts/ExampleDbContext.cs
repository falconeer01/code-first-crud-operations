using System;
using DatabaseExample.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatabaseExample.Repositories.Contexts;
public class ExampleDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-2AK7Q68\\SQLEXPRESS;Database=Example;Integrated Security=True;TrustServerCertificate=True");
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Personal> Personals { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Jobber> Jobbers { get; set; }
}