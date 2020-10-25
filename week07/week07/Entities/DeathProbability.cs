using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week07.Entities
{
    public class DeathProbability
    {
        public double Age { get; set; }

        public Gender Gender { get; set; }
        
        public double ProbabilityOfDeath { get; set; }
    }
}
