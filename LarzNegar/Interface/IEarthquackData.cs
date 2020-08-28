﻿using LarzNegar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LarzNegar.Interface
{
    public interface IEarthquackeData
    {
        IEnumerable<Larz> GetAll(string search);
    }

    public class InMemoryEarthquackeData : IEarthquackeData
    {
        List<Larz> Larzs;

        public InMemoryEarthquackeData()
        {
            Larzs = new List<Larz>()
            {
                new Larz {Id = 1, Type = FaultType.StrikeSlip, Magnitude = 6.6, Depth = 15, Location = "مشهد"},
                new Larz {Id = 2, Type = FaultType.ObliqueSlip, Magnitude = 2.6, Depth = 25, Location = "کرمان"},
                new Larz {Id = 3, Type = FaultType.DipSlip, Magnitude = 1.6, Depth = 5, Location = "شیراز"},
                new Larz {Id = 4, Type = FaultType.StrikeSlip, Magnitude = 6.6, Depth = 15, Location = "مشهد"},
                new Larz {Id = 5, Type = FaultType.ObliqueSlip, Magnitude = 2.6, Depth = 25, Location = "یزد"},
                new Larz {Id = 6, Type = FaultType.DipSlip, Magnitude = 1.6, Depth = 5, Location = "کرمان"},
                new Larz {Id = 7, Type = FaultType.StrikeSlip, Magnitude = 6.6, Depth = 15, Location = "زنجان"},
                new Larz {Id = 8, Type = FaultType.ObliqueSlip, Magnitude = 2.6, Depth = 25, Location = "یزد"},
                new Larz {Id = 9, Type = FaultType.DipSlip, Magnitude = 1.6, Depth = 5, Location = "شیراز"},
                new Larz {Id = 10, Type = FaultType.StrikeSlip, Magnitude = 6.6, Depth = 15, Location = "شمال"},
                new Larz {Id = 11, Type = FaultType.ObliqueSlip, Magnitude = 2.6, Depth = 25, Location = "یزد"},
                new Larz {Id = 12, Type = FaultType.DipSlip, Magnitude = 1.6, Depth = 5, Location = "شیراز"},
            };
        }

        public IEnumerable<Larz> GetAll(string search = null)
        {
            return from l in Larzs
                   where string.IsNullOrEmpty(search) || l.Location.StartsWith(search)
                   orderby l.Id
                   select l;
        }
    }
}
