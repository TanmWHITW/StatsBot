using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsBot.DAL.Models
{
    public class Kingdom: Entity
    {
        public int Power => Governors == null ? 0 : Governors.Sum(x => x.Power);
        public ICollection<Governor>? Governors { get; set; }
        public ICollection<KingdomGuild>? KingdomGuilds { get; set; }
    }
}
