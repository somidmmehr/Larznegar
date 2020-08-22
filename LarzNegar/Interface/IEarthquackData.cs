using LarzNegar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LarzNegar.Interface
{
    public interface IEarthquackeData
    {
        IEnumerable<Larz> GetAll();
    }

    public class InMemoryEarthquackeData : IEarthquackeData
    {
        List<Larz> Larzs;

        public InMemoryEarthquackeData()
        {
            Larzs = new List<Larz>()
            {
                new Larz {Id = 1, Type = FaultType.StrikeSlip, Magnitude = 6.6, Depth = 15},
                new Larz {Id = 2, Type = FaultType.ObliqueSlip, Magnitude = 2.6, Depth = 25},
                new Larz {Id = 3, Type = FaultType.DipSlip, Magnitude = 1.6, Depth = 5},
            };
        }

        public IEnumerable<Larz> GetAll()
        {
            return from l in Larzs
                   orderby l.Id
                   select l;
        }
    }
}
