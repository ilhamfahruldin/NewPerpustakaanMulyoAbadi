using Microsoft.EntityFrameworkCore;
using Perpustakaan.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;

namespace Perpustakaan.Data
{
    public class PerpusDbContext : IdentityDbContext<Pembaca>
    {
    public PerpusDbContext (DbContextOptions<PerpusDbContext> options) : base(options)
    { }
    public DbSet <Buku> Bukus { get; set; }
    public DbSet<Details> Details { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
                .HasData(new [] {
                    new IdentityRole("Admin"),
                    new IdentityRole("User")
                });

            var hasher = new PasswordHasher<Pembaca>();
            var admin = new Pembaca
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Farell",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "dyasrestu@admin.com",
                NormalizedEmail = "DYASRESTU@ADMIN.COM",
                EmailConfirmed = true
            };
            admin.PasswordHash = hasher.HashPassword(admin, "Farell123!");
            builder.Entity<Pembaca>()
                .HasData(admin);
        }

    }
}


