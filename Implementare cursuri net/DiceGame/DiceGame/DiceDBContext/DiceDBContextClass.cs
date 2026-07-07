using DiceGame.PlayerSpace;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiceGame.DiceDBContext
{
    public class DiceDBContextClass : DbContext
    {
        public DbSet<Player> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=DiceGameDB;
Trusted_Connection=True; multipleactiveresultsets=True;");
        }
    }
}
