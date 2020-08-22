using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LarzNegar.Model
{
    public class Larz
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int Duration { get; set; }
        public double Magnitude { get; set; }
        public double Depth { get; set; }
        public string Location { get; set; }
        public Array Epicenter { get; set; }
        public FaultType Type { get; set; }
        public double CasualtyKilled { get; set; }
        public double CasualtyInjured { get; set; }
        public double CasualtyDisplaced { get; set; }
        public string Image { get; set; }
        public string SourceURL { get; set; }
        public DateTime CreateInDB { get; set; }
        public DateTime ChangeInDB { get; set; }

    }
}
