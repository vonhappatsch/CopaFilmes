using CopaFilmesAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaFilmesAPI.Domain.Services
{
    public class MovieMatch : IMovieMatch
    {
        public List<Competitors> FirstRound(List<Competitors> competitors)
        {
            competitors = competitors.OrderBy(m => m.Titulo).ToList();

            List<Competitors> result = new List<Competitors>();

            List<Competitors> firstPair = new List<Competitors>();
            firstPair.Add(competitors[0]);
            firstPair.Add(competitors[7]);
            firstPair.OrderByDescending(m => m.Nota).ThenBy(m => m.Titulo).ToList();
            result.Add(firstPair[0]);

            List<Competitors> secondPair = new List<Competitors>();
            secondPair.Add(competitors[1]);
            secondPair.Add(competitors[6]);
            secondPair.OrderByDescending(m => m.Nota).ThenBy(m => m.Titulo).ToList();
            result.Add(secondPair[0]);

            List<Competitors> thirdPair = new List<Competitors>();
            thirdPair.Add(competitors[2]);
            thirdPair.Add(competitors[5]);
            thirdPair.OrderByDescending(m => m.Nota).ThenBy(m => m.Titulo).ToList();
            result.Add(thirdPair[0]);

            List<Competitors> fourthPair = new List<Competitors>();
            fourthPair.Add(competitors[3]);
            fourthPair.Add(competitors[4]);
            fourthPair.OrderByDescending(m => m.Nota).ThenBy(m => m.Titulo).ToList();
            result.Add(fourthPair[0]);

            return result;
        }

        public List<Competitors> SecondRound(List<Competitors> competitors)
        {
            List<Competitors> newResult = new List<Competitors>();

            List<Competitors> firstPair = new List<Competitors>();
            firstPair.Add(competitors[0]);
            firstPair.Add(competitors[1]);
            firstPair.OrderByDescending(m => m.Nota).ThenBy(m => m.Titulo).ToList();
            newResult.Add(firstPair[0]);

            List<Competitors> secondPair = new List<Competitors>();
            secondPair.Add(competitors[2]);
            secondPair.Add(competitors[3]);
            secondPair.OrderByDescending(m => m.Nota).ThenBy(m => m.Titulo).ToList();
            newResult.Add(secondPair[0]);

            return newResult;
        }

        public List<Competitors> FinalRound(List<Competitors> competitors)
        {
            List<Competitors> finalPair = new List<Competitors>();
            finalPair.Add(competitors[0]);
            finalPair.Add(competitors[1]);
            return finalPair.OrderByDescending(m => m.Nota).ThenBy(m => m.Titulo).ToList();
        }
    }
}
