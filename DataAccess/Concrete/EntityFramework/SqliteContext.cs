using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace DataAccess.Concrete.EntityFramework
{
    // veri tabani ile projedeki classlari iliskilendir
    public class SqliteContext : DbContext
    {
        // veri tabani baglantisini saglar
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source="+Path.GetFullPath("AppDataBase.db"));
        }

        // User class'i ile Users Tablosunu iliskilendirir
        public DbSet<Users> Users { get; set; }

        // Project class'i ile Projects Tablosunu iliskilendirir
        public DbSet<Items> Items { get; set; }
    }
}
