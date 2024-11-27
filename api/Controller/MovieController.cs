using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Mapper;
using Microsoft.AspNetCore.Mvc;

namespace api.Controller
{
    [Route("api/movies")]
    [ApiController]
    public class MovieController: ControllerBase
    {
        private readonly ApplicationDBContext _applicationDBContext;

        public MovieController(ApplicationDBContext applicationDBContext)
        {
            _applicationDBContext = applicationDBContext;
        }

        //todo read about defered execution
        [HttpGet]
        public IActionResult FindAll() 
        {
            var movies = _applicationDBContext.Movie.ToList()
            .Select(movie => movie.ModelToDto());

            return Ok(movies);
        }

         [HttpGet("{id}")]
        public IActionResult FindById([FromRoute] int id) 
        {
            var movie = _applicationDBContext.Movie.Find(id);

            if (movie == null) {
                return NotFound("Mvoie not found by id: " + id);
            }

            return Ok(movie);
        }

        // [HttpPost("{id}")]
        // public IActionResult Create() 
        // {
        //     //todo read about defered execution
        //     var movie = _applicationDBContext.Movie.Add(id);

        //     if (movie == null) {
        //         return NotFound("Movie not found by id: " + id);
        //     }

        //     return Ok(movie);
        // }
    }
}