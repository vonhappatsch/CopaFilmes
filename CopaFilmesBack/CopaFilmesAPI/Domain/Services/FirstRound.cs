using CopaFilmesAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaFilmesAPI.Domain.Services
{
    public class FirstRound : IFirstRound
    {
        public List<Competitors> FirstRoundMatch(List<Competitors> competitors)
        {
            competitors = competitors.OrderBy(m => m.Titulo).ToList();

            List<Competitors> result = new List<Competitors>();

            List<Competitors> firstPair = competitors.Take(1).TakeLast(1).ToList();
            result.Add(firstPair.First());

            List<Competitors> secondPair = new List<Competitors>();
            secondPair.Add(competitors.Skip(1).Take(1).ToList().First());
            secondPair.Add(competitors.Skip(5).Take(1).ToList().First());
            result.Add(secondPair.OrderByDescending(m => m.Nota).
                ThenBy(m => m.Titulo).ToList().First());

            List<Competitors> thirdPair = new List<Competitors>();
            thirdPair.Add(competitors.Skip(2).Take(1).ToList().First());
            thirdPair.Add(competitors.Skip(4).Take(1).ToList().First());
            result.Add(thirdPair.OrderByDescending(m => m.Nota).
                ThenBy(m => m.Titulo).ToList().First());

            List<Competitors> fourthPair = new List<Competitors>();
            fourthPair.Add(competitors.Skip(3).Take(1).ToList().First());
            fourthPair.Add(competitors.Skip(5).Take(1).ToList().First());
            result.Add(fourthPair.OrderByDescending(m => m.Nota).
                ThenBy(m => m.Titulo).ToList().First());

            return result;
        }
    }
}
