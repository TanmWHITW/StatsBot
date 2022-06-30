using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsBot.DAL.Models
{
    public class Governor: Entity
    {
        public string GovernorName { get; set; } = string.Empty;
        public int Power { get; set; }
        public int Kills { get; set; }
        public int T5Kills { get; set; }
        public int T4Kills { get; set; }
        public int Dead { get; set; }
        public int ResourcesGathered { get; set; }
        public int ResourcesShared { get; set; }
        public Kingdom? Kingdom { get; set; }
    }
}
