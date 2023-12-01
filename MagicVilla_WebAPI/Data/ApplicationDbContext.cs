using MagicVilla_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_WebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Villa> Villas { get; set; }
    }
}
