using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace NbaPlayersApp.Models
{
    public class PlayerContext : DbContext
    {

        public PlayerContext(DbContextOptions<PlayerContext> options) : base(options)
        {

        }

        public DbSet<Player> players { get; set; }
    }
}
