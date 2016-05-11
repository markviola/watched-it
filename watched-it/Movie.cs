using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace watched_it
{
    public class Movie
    {
        private string Name;
        private int ReleaseYear;
        private double UserRating;
        private double IMDBRating;
        private string Filepath;
        private string PicFilepath;
        private bool Watched;

        public Movie(string name, int releaseYear, double userRating, double imdbRating, 
            string filepath, string picFilepath)
        {
            Name = name;
            ReleaseYear = releaseYear;
            UserRating = userRating;    // Negative if movie is not rated by user
            IMDBRating = imdbRating;    
            Filepath = filepath;
            PicFilepath = picFilepath;
            Watched = false;
        }

        // Getters and setters

        public string getName() { return Name; }
        public void setName(string name) { Name = name; }

        public int getReleaseYear() { return ReleaseYear; }
        public void setReleaseYear(int releaseYear) { ReleaseYear = releaseYear; }

        public double getUserRating() { return UserRating; }
        public void setUserRating(double userRating) { UserRating = userRating; }

        public double getIMDBRating() { return IMDBRating; }
        public void setIMDBRating(double imdbRating) { IMDBRating = imdbRating; }

        public string getFilepath() { return Filepath; }
        public void setFilepath(string filepath)  { Filepath = filepath; }

        public string getPicFilepath() { return PicFilepath; }
        public void setPicFilepath(string picFilepath) { PicFilepath = picFilepath; }

        public bool getWatched() { return Watched; }
        public void setWatched(bool watched) { Watched = watched; }

    }
}
