using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsBot.DAL.Models
{
    public class Guild : Entity
    {
        public string GuildName { get; set; } = string.Empty;
        public bool HasAccess { get; set; } = false;
        public ICollection<KingdomGuild>? KingdomGuilds { get; set; }

    }
}
