﻿using CopaFilmesAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaFilmesAPI.Domain.Services
{
    public interface IMovieMatch
    {
        List<Competitors> Match(List<Competitors> competitors);
    }
}
