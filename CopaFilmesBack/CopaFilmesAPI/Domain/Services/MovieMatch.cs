using CopaFilmesAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaFilmesAPI.Domain.Services
{
    public class MovieMatch : IMovieMatch
    {
        public List<Competitors> Match(List<Competitors> competitors)
        {
            List<Competitors> moviesToCompete = competitors;

            var firstRound = new FirstRound();
            var secondRound = new SecondRound();
            var finalRound = new FinalRound();

            firstRound.FirstRoundMatch(moviesToCompete);
            secondRound.SecondRoundMatch(moviesToCompete);
            return finalRound.FinalRoundMatch(moviesToCompete);
        }
    }
}
