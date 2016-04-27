using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace watched_it
{
    class MovieManager
    {
        private List<Movie> Movies;

        public MovieManager()
        {
            
        }


        public List<Movie> getMovies()
        {
            return Movies;
        }

        public void setMovies(List<Movie> movies)
        {
            Movies = movies;
        }

        public void addMovie(Movie movie)
        {
            Movies.Add(movie);
        }

        public void deleteMovie(Movie movie)
        {
            Movies.Remove(movie);
        }


    }
}
