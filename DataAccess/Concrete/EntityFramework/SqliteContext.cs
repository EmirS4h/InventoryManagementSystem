﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    // veri tabani ile projedeki classlari iliskilendir
    public class SqliteContext : DbContext
    {
        // veri tabani baglantisini saglar
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\Emir\source\repos\SchoolProject\MainUI\AppDataBase.db;");
        }

        // User class'i ile Users Tablosunu iliskilendirir
        public DbSet<User> Users { get; set; }

        // Project class'i ile Projects Tablosunu iliskilendirir
        public DbSet<Project> Projects { get; set; }

        // Todo class'i ile Todos Tablosunu iliskilendirir
        public DbSet<Todo> Todos { get; set; }
    }
}
