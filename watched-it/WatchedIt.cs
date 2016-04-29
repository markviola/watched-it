using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace watched_it
{
    public partial class WatchedIt : Form
    {
        MovieDB dbMovies = new MovieDB();
        MovieManager movieManager = new MovieManager();

        string[] allMovies;
        string[] allMoviesPaths;
        ImageList imgList = new ImageList();
        String XMLlocation = Application.StartupPath + @"\XMLMovies.xml";

        public WatchedIt()
        {
            InitializeComponent();

            if (File.Exists(XMLlocation))
            {
                dbMovies.ReadXml(XMLlocation);
                getMovieDBData();
                populateListView();
            }
            
            //for (int i = 0; i < 3; i++)
            //{
            //    DataRow drRows = dtMovies.NewRow();

            //    drRows["MovieName"] = "Rocky";
            //    drRows["ReleaseYear"] = 1998;
            //    drRows["UserRating"] = i * 100.0;
            //    drRows["IMDBRating"] = i * 10.0;
            //    drRows["Path"] = "c://okdawg";
            //    dtMovies.Rows.Add(drRows);
            //}


            //dtMovies.WriteXml(XMLlocation);

            //dbMovies.ReadXml(XMLlocation);
            //getMovieDBData();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(searchInput.Text);
            string searchText = searchInput.Text;


            for(int i=0; i<movieManager.getMovies().Count; i++)
            {
                if (movieManager.getMovies()[i].getName().Contains(searchInput.Text))
                {

                }
            }
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0; i<MovieList.SelectedItems.Count; i++)
            {
                Process.Start(@MovieList.SelectedItems[i].SubItems[4].Text);
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            // Clear current Movie list
            dbMovies.Clear();
            
            // Get the DataTable for Movies
            DataTable dtMovies = dbMovies.Tables["Movies"];

            // Prompt User for directory path for movie lists
            // Note: Each movie must be in a subdirectory of this selected directory
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if(fbd.ShowDialog() == DialogResult.OK)
            {
                allMovies = System.IO.Directory.GetDirectories(@fbd.SelectedPath, "*", System.IO.SearchOption.AllDirectories);

                allMoviesPaths = new string[allMovies.Length];
                for (int k = 0; k < allMoviesPaths.Length; k++) { allMoviesPaths[k] = ""; }

                for (int i = 0; i < allMovies.Length; i++)
                {
                    // Get .mkv, .mp4, and .avi files
                    string[] mkvFiles = System.IO.Directory.GetFiles(allMovies[i], "*.mkv", System.IO.SearchOption.AllDirectories);
                    string[] mp4Files = System.IO.Directory.GetFiles(allMovies[i], "*.mp4", System.IO.SearchOption.AllDirectories);
                    string[] aviFiles = System.IO.Directory.GetFiles(allMovies[i], "*.avi", System.IO.SearchOption.AllDirectories);
                    if (mkvFiles.Length > 0)
                    {
                        mkvFiles.CopyTo(allMoviesPaths, i);
                    }
                    else if (mp4Files.Length > 0)
                    {
                        mp4Files.CopyTo(allMoviesPaths, i);
                    }
                    else if (aviFiles.Length > 0)
                    {
                        aviFiles.CopyTo(allMoviesPaths, i);
                    }

                    if (!allMoviesPaths[i].Equals(""))
                    {
                        DataRow movieRow = dtMovies.NewRow();
                        movieRow["MovieName"] = allMoviesPaths[i].Substring(allMovies[i].Length + 1);
                        movieRow["ReleaseYear"] = 2000;
                        movieRow["UserRating"] = -1;
                        movieRow["IMDBRating"] = -1;
                        movieRow["Path"] = allMoviesPaths[i];
                        dtMovies.Rows.Add(movieRow);
                    }
                }

                dtMovies.WriteXml(XMLlocation);         // Store movie data in XML
                getMovieDBData();                       // Populate MovieManager
                populateListView();                     // Populate ListView
            }
            
        }

        private void MovieList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string imgPath = System.AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\imgs";
            string[] images = System.IO.Directory.GetFiles(@imgPath, "*.png", System.IO.SearchOption.AllDirectories);

            // Store all images from the imgs directory to the images array
            for (int i = 0; i < images.Length; i++)
            {
                imgList.Images.Add(i.ToString(), Image.FromFile(images[i]));
            }

            // Put all images from image array to ListView
            for (int j=0; j<images.Length; j++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = j;
                someIMGList.Items.Add(lvi);
            }

            // Set the image lists for the ListView
            someIMGList.SmallImageList = imgList;
            someIMGList.LargeImageList = imgList;
        }

        // Display the movies in standard image grid form
        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieList.View = View.LargeIcon;
        }

        // Display the movies in grid form, but with smaller icons
        private void imageListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieList.View = View.SmallIcon;
        }

        // Display the movies using a basic text list format
        private void textListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieList.View = View.Details;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i=0; i< dbMovies.Tables["Movies"].Rows.Count; i++)
            {
                //MessageBox.Show(dbMovies.Tables["Movies"].Rows[i]["MovieName"].ToString() + " " +
                //    dbMovies.Tables["Movies"].Rows[i]["Path"].ToString() + " " +
                //    dbMovies.Tables["Movies"].Rows[i]["UserRating"].ToString() + " " +
                //    dbMovies.Tables["Movies"].Rows[i]["IMDBRating"].ToString());

                if (string.IsNullOrEmpty(dbMovies.Tables["Movies"].Rows[i]["ReleaseYear"].ToString()))
                {
                    MessageBox.Show(dbMovies.Tables["Movies"].Rows[i]["MovieName"].ToString());
                }
            }
        }

        // Populate the MovieManager object with the movie data found in the database
        private void getMovieDBData()
        {
            movieManager.clearMovies();
            for (int i = 0; i < dbMovies.Tables["Movies"].Rows.Count; i++)
            {
                Movie tempMovie = new Movie(dbMovies.Tables["Movies"].Rows[i]["MovieName"].ToString(),
                    Int32.Parse(dbMovies.Tables["Movies"].Rows[i]["ReleaseYear"].ToString()),
                    double.Parse(dbMovies.Tables["Movies"].Rows[i]["UserRating"].ToString()),
                    double.Parse(dbMovies.Tables["Movies"].Rows[i]["IMDBRating"].ToString()),
                    dbMovies.Tables["Movies"].Rows[i]["Path"].ToString()
                    );
                movieManager.addMovie(tempMovie);
            }
        }

        // Populate ListView with Movie data
        private void populateListView()
        {
            MovieList.Items.Clear();
            for (int i=0; i<movieManager.getMovies().Count; i++)
            {
                ListViewItem lvi = new ListViewItem(movieManager.getMovies()[i].getName());
                lvi.SubItems.Add(movieManager.getMovies()[i].getReleaseYear().ToString());

                if(movieManager.getMovies()[i].getUserRating() != -1)
                {
                    lvi.SubItems.Add(movieManager.getMovies()[i].getUserRating().ToString());
                }
                else {
                    lvi.SubItems.Add("N/A");
                }

                if (movieManager.getMovies()[i].getIMDBRating() != -1)
                {
                    lvi.SubItems.Add(movieManager.getMovies()[i].getIMDBRating().ToString());
                }
                else
                {
                    lvi.SubItems.Add("N/A");
                }

                lvi.SubItems.Add(movieManager.getMovies()[i].getFilepath());
                MovieList.Items.Add(lvi);
            }
        }

        // All sorting button calls

        private void increasingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movieManager.sortMoviesAlphaIncr(0, movieManager.getMovies().Count - 1);
            populateListView();
        }

        private void decreasingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movieManager.sortMoviesAlphaDecr(0, movieManager.getMovies().Count - 1);
            populateListView();
        }

        private void increasingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            movieManager.sortMoviesReleaseYearIncr(0, movieManager.getMovies().Count - 1);
            populateListView();
        }

        private void decreasingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            movieManager.sortMoviesReleaseYearDecr(0, movieManager.getMovies().Count - 1);
            populateListView();
        }

        private void increasingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            movieManager.sortMoviesUserRatingIncr(0, movieManager.getMovies().Count - 1);
            populateListView();
        }

        private void decreasingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            movieManager.sortMoviesUserRatingDecr(0, movieManager.getMovies().Count - 1);
            populateListView();
        }

        private void increasingToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            movieManager.sortMoviesIMDBRatingIncr(0, movieManager.getMovies().Count - 1);
            populateListView();
        }

        private void decreasingToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            movieManager.sortMoviesIMDBRatingDecr(0, movieManager.getMovies().Count - 1);
            populateListView();
        }
    }
}
