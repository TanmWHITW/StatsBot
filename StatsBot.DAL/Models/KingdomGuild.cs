using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsBot.DAL.Models
{
    public class KingdomGuild
    {
        public int KingdomId { get; set; }
        public Kingdom? Kingdom { get; set; }
        public int GuildId { get; set; }
        public Guild? Guild { get; set; }

    }
}
