using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dto;
using Model;

namespace api.Mapper
{
    public static class MovieMapper
    {
        public static MovieDto ModelToDto(this Movie movie) {

            return new MovieDto {
                Id = movie.Id,
                Description = movie.Description,
                Price = movie.Price
            };
        }
    }
}