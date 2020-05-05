using CopaFilmesAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaFilmesAPI.Domain.Services
{
    public class FinalRound : IFinalRound
    {
        public List<Competitors> FinalRoundMatch(List<Competitors> competitors)
        {
            List<Competitors> finalPair = competitors.OrderByDescending(m => m.Nota).
                ThenBy(m => m.Titulo).Take(2).ToList();

            return finalPair;
        }
    }
}
