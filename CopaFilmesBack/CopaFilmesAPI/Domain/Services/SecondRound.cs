using CopaFilmesAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaFilmesAPI.Domain.Services
{
    public class SecondRound : ISecondRound
    {
        public List<Competitors> SecondRoundMatch(List<Competitors> competitors)
        {
            List<Competitors> newResult = new List<Competitors>();

            List<Competitors> firstPair = competitors.OrderByDescending(m => m.Nota).
                ThenBy(m => m.Titulo).Take(2).ToList();
            newResult.Add(firstPair.First());

            List<Competitors> secondPair = competitors.OrderByDescending(m => m.Nota).
                ThenBy(m => m.Titulo).Skip(2).Take(2).ToList();
            newResult.Add(secondPair.First());

            return newResult;
        }
    }
}
