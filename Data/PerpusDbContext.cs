using Microsoft.EntityFrameworkCore;
using Perpustakaan.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Perpustakaan.Data
{
public class PerpusDbContext : IdentityDbContext<Pembaca>
{
public PerpusDbContext (DbContextOptions<PerpusDbContext> options) : base(options)
{ }
public DbSet <Buku> Bukus { get; set; }

}
}
