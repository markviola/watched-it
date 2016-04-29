﻿using System;
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
            Movies = new List<Movie>();
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

        public void clearMovies()
        {
            Movies.Clear();
        }

        // Returns the list of movies that have been watched
        // out of all movies in the database
        public List<Movie> getWatchedList()
        {
            List<Movie> watchedMovies = new List<Movie>();

            for(int i=0; i<Movies.Count; i++)
            {
                if (Movies[i].getWatched())
                {
                    watchedMovies.Add(Movies[i]);
                }
            }

            return watchedMovies;
        }

        // Returns the list of movies that have been watched 
        // out of all the movies from the input list
        public List<Movie> getWatchedList(List<Movie> movies)
        {
            List<Movie> watchedMovies = new List<Movie>();

            for (int i = 0; i < movies.Count; i++)
            {
                if (Movies[i].getWatched())
                {
                    watchedMovies.Add(movies[i]);
                }
            }

            return watchedMovies;
        }

        // Sort movies by alphabetical name in increasing order
        public void sortMoviesAlphaIncr(int left, int right)
        {
            int i = left, j = right;
            Movie pivot = Movies[(left + right) / 2];

            while(i <= j)
            {
                while(Movies[i].getName().CompareTo(pivot.getName()) < 0) { i++; }
                while (Movies[j].getName().CompareTo(pivot.getName()) > 0) { j--; }

                if( i <= j)
                {
                    // Swap elements at i and j
                    Movie temp = Movies[j];
                    Movies[j] = Movies[i];
                    Movies[i] = temp;

                    i++;
                    j--;
                }
            }

            if(left < j) { sortMoviesAlphaIncr(left, j); }
            if(i < right) { sortMoviesAlphaIncr(i, right); }
        }

        // Sort movies by alphabetical name in decreasing order
        public void sortMoviesAlphaDecr(int left, int right)
        {
            int i = left, j = right;
            Movie pivot = Movies[(left + right) / 2];

            while (i <= j)
            {
                while (Movies[i].getName().CompareTo(pivot.getName()) > 0) { i++; }
                while (Movies[j].getName().CompareTo(pivot.getName()) < 0) { j--; }

                if (i <= j)
                {
                    // Swap elements at i and j
                    Movie temp = Movies[j];
                    Movies[j] = Movies[i];
                    Movies[i] = temp;

                    i++;
                    j--;
                }
            }

            if (left < j) { sortMoviesAlphaDecr(left, j); }
            if (i < right) { sortMoviesAlphaDecr(i, right); }
        }

        // Sort movies by release year in increasing order
        public void sortMoviesReleaseYearIncr(int left, int right)
        {
            int i = left, j = right;
            Movie pivot = Movies[(left + right) / 2];

            while (i <= j)
            {
                while (Movies[i].getReleaseYear() < pivot.getReleaseYear()) { i++; }
                while (Movies[j].getReleaseYear() > pivot.getReleaseYear()) { j--; }

                if (i <= j)
                {
                    // Swap elements at i and j
                    Movie temp = Movies[j];
                    Movies[j] = Movies[i];
                    Movies[i] = temp;

                    i++;
                    j--;
                }
            }

            if (left < j) { sortMoviesReleaseYearIncr(left, j); }
            if (i < right) { sortMoviesReleaseYearIncr(i, right); }
        }

        // Sort movies by release year in decreasing order
        public void sortMoviesReleaseYearDecr(int left, int right)
        {
            int i = left, j = right;
            Movie pivot = Movies[(left + right) / 2];

            while (i <= j)
            {
                while (Movies[i].getReleaseYear() > pivot.getReleaseYear()) { i++; }
                while (Movies[j].getReleaseYear() < pivot.getReleaseYear()) { j--; }

                if (i <= j)
                {
                    // Swap elements at i and j
                    Movie temp = Movies[j];
                    Movies[j] = Movies[i];
                    Movies[i] = temp;

                    i++;
                    j--;
                }
            }

            if (left < j) { sortMoviesReleaseYearDecr(left, j); }
            if (i < right) { sortMoviesReleaseYearDecr(i, right); }
        }

        // Sort movies by user rating in increasing order
        public void sortMoviesUserRatingIncr(int left, int right)
        {
            int i = left, j = right;
            Movie pivot = Movies[(left + right) / 2];

            while (i <= j)
            {
                while (Movies[i].getUserRating() < pivot.getUserRating()) { i++; }
                while (Movies[j].getUserRating() > pivot.getUserRating()) { j--; }

                if (i <= j)
                {
                    // Swap elements at i and j
                    Movie temp = Movies[j];
                    Movies[j] = Movies[i];
                    Movies[i] = temp;

                    i++;
                    j--;
                }
            }

            if (left < j) { sortMoviesUserRatingIncr(left, j); }
            if (i < right) { sortMoviesUserRatingIncr(i, right); }
        }

        // Sort movies by user rating in decreasing order
        public void sortMoviesUserRatingDecr(int left, int right)
        {
            int i = left, j = right;
            Movie pivot = Movies[(left + right) / 2];

            while (i <= j)
            {
                while (Movies[i].getUserRating() > pivot.getUserRating()) { i++; }
                while (Movies[j].getUserRating() < pivot.getUserRating()) { j--; }

                if (i <= j)
                {
                    // Swap elements at i and j
                    Movie temp = Movies[j];
                    Movies[j] = Movies[i];
                    Movies[i] = temp;

                    i++;
                    j--;
                }
            }

            if (left < j) { sortMoviesUserRatingDecr(left, j); }
            if (i < right) { sortMoviesUserRatingDecr(i, right); }
        }

        // Sort movies by IMDB rating in increasing order
        public void sortMoviesIMDBRatingIncr(int left, int right)
        {
            int i = left, j = right;
            Movie pivot = Movies[(left + right) / 2];

            while (i <= j)
            {
                while (Movies[i].getIMDBRating() < pivot.getIMDBRating()) { i++; }
                while (Movies[j].getIMDBRating() > pivot.getIMDBRating()) { j--; }

                if (i <= j)
                {
                    // Swap elements at i and j
                    Movie temp = Movies[j];
                    Movies[j] = Movies[i];
                    Movies[i] = temp;

                    i++;
                    j--;
                }
            }

            if (left < j) { sortMoviesIMDBRatingIncr(left, j); }
            if (i < right) { sortMoviesIMDBRatingIncr(i, right); }
        }

        // Sort movies by IMDB rating in decreasing order
        public void sortMoviesIMDBRatingDecr(int left, int right)
        {
            int i = left, j = right;
            Movie pivot = Movies[(left + right) / 2];

            while (i <= j)
            {
                while (Movies[i].getIMDBRating() > pivot.getIMDBRating()) { i++; }
                while (Movies[j].getIMDBRating() < pivot.getIMDBRating()) { j--; }

                if (i <= j)
                {
                    // Swap elements at i and j
                    Movie temp = Movies[j];
                    Movies[j] = Movies[i];
                    Movies[i] = temp;

                    i++;
                    j--;
                }
            }

            if (left < j) { sortMoviesIMDBRatingDecr(left, j); }
            if (i < right) { sortMoviesIMDBRatingDecr(i, right); }
        }
    }
}
