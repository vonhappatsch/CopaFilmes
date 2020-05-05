using System;
using System.Collections.Generic;
using CopaFilmesAPI.Domain.Models;
using System.Linq;
using System.Threading.Tasks;

namespace CopaFilmesAPI.Domain.Services
{
    public interface IFinalRound
    {
        List<Competitors> FinalRoundMatch(List<Competitors> competitors);
    }
}
