using CopaFilmesAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaFilmesAPI.Domain.Services
{
    public interface IMovieMatch
    {
        List<Competitors> FirstRound(List<Competitors> movies);

        List<Competitors> SecondRound(List<Competitors> movies);

        List<Competitors> FinalRound(List<Competitors> movies);
    }
}
