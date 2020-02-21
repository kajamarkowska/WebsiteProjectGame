using Microsoft.EntityFrameworkCore;
using ProjectGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectGame.Data
{
    public class Db : DbContext
    {
        public Db(DbContextOptions<Db> options) : base (options)
        {

        }

        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().ToTable("Game");
        }
    }
}
