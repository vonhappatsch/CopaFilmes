using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaFilmesAPI.Domain.Models;
using CopaFilmesAPI.Domain.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CopaFilmesAPI.Controllers
{
    [EnableCors("EnableCORS")]
    public class CopaFilmesController : ControllerBase
    {
        private readonly ICopaFilmesService _copaFilmesService;
        private readonly IMovieMatch _movieMatch;

        public CopaFilmesController(ICopaFilmesService copaFilmesService, IMovieMatch movieMatch)
        {
            _copaFilmesService = copaFilmesService;
            _movieMatch = movieMatch;
        }

        [HttpGet]
        [Route("/api/allmovies")]
        public async Task<IActionResult> GetAllMovies()
        {
            var result = await _copaFilmesService.GetAllMovies();

            return Ok(result);

        }

        [HttpPost]
        [Route("/api/championship")]
        public IActionResult FinalRound([FromBody] List<Competitors> competitors)
        { 
            try
            {
                List<Competitors> moviesToMatch = competitors;
                var result = _movieMatch.Match(moviesToMatch);

                return Ok(result);
            }
            catch (Exception)
            {

                return BadRequest("Infelizmente não pudemos realizar o campeonato.");
            }
        }
    }
}