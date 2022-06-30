using Microsoft.EntityFrameworkCore;
using StatsBot.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsBot.DAL
{
    public class StatsContext: DbContext
    {
        public StatsContext(DbContextOptions options) : base(options) { }

        public DbSet<Governor>? Governors { get; set; }
        public DbSet<Kingdom>? Kingdoms { get; set; }
        public DbSet<Guild>? Guilds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kingdom>()
                .HasMany(g => g.Governors)
                .WithOne(k => k.Kingdom);
            modelBuilder.Entity<KingdomGuild>()
                .HasKey(kg => new {kg.KingdomId, kg.GuildId});
            modelBuilder.Entity<KingdomGuild>()
                .HasOne(kg => kg.Kingdom)
                .WithMany(k => k.KingdomGuilds)
                .HasForeignKey(kg => kg.KingdomId);
            modelBuilder.Entity<KingdomGuild>()
                .HasOne(kg => kg.Guild)
                .WithMany(g => g.KingdomGuilds)
                .HasForeignKey(kg => kg.GuildId);
        }
    }
}
