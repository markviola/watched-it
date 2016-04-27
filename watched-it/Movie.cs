using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace watched_it
{
    class Movie
    {
        private string Name;
        private int ReleaseYear;
        private int Rating;
        private string Filepath;
        private bool Watched;

        public Movie(string name, int releaseYear, string filepath)
        {
            Name = name;
            ReleaseYear = releaseYear;
            Rating = -1;    // Negative if movie is not rated by user
            Filepath = filepath;
            Watched = false;
        }

        public string getName()
        {
            return Name;
        }

        public void setName(string name)
        {
            Name = name;
        }

        public int getReleaseYear()
        {
            return ReleaseYear;
        }

        public void setReleaseYear(int releaseYear)
        {
            ReleaseYear = releaseYear;
        }

        public int getRating()
        {
            return Rating;
        }

        public void setRating(int rating)
        {
            Rating = rating;
        }

        public string getFilepath()
        {
            return Filepath;
        }

        public void setFilepath(string filepath)
        {
            Filepath = filepath;
        }

        public bool getWatched()
        {
            return Watched;
        }

        public void setWatched(bool watched)
        {
            Watched = watched;
        }

    }
}
