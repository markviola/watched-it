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
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;

namespace watched_it
{
    public partial class WatchedIt : Form
    {
        // Initialize data holders
        MovieDB dbMovies = new MovieDB();
        MovieManager movieManager = new MovieManager();

        // Initialize web object
        // WebClient webClient = new WebClient();

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
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        // Filters the movies shown in the ListView dependant on the input search text
        private void searchButton_Click(object sender, EventArgs e)
        {
            movieManager.clearFilteredMovies();
            for(int i=0; i<movieManager.getMovies().Count; i++)
            {
                if (movieManager.getMovies()[i].getName().ToLower().Contains(searchInputTextBox.Text.ToLower()))
                {
                    movieManager.addFilteredMovie(movieManager.getMovies()[i]);
                }
            }
            populateListView();
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
            //string imgPath = System.AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\imgs";
            //string[] images = System.IO.Directory.GetFiles(@imgPath, "*.png", System.IO.SearchOption.AllDirectories);

            //// Store all images from the imgs directory to the images array
            //for (int i = 0; i < images.Length; i++)
            //{
            //    imgList.Images.Add(i.ToString(), Image.FromFile(images[i]));
            //}

            //// Put all images from image array to ListView
            //for (int j = 0; j < images.Length; j++)
            //{
            //    ListViewItem lvi = new ListViewItem();
            //    lvi.ImageIndex = j;
            //    someIMGList.Items.Add(lvi);
            //}

            //// Set the image lists for the ListView
            //someIMGList.SmallImageList = imgList;
            //someIMGList.LargeImageList = imgList;

            // Clear current Movie list
            dbMovies.Clear();

            // Get the DataTable for Movies
            DataTable dtMovies = dbMovies.Tables["Movies"];

            // Prompt User for directory path for movie lists
            // Note: Each movie must be in a subdirectory of this selected directory
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
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
                        string movieFileName = allMoviesPaths[i].Substring(allMovies[i].Length + 1);
                        movieFileName = movieFileName.Substring(0, movieFileName.Length - 10);       //file extension and movie year in file name
                        string imdbSearch = @"http://www.imdb.com/find?q=" + @movieFileName + @"&s=tt&ttype=ft&ref_=fn_ft";
                        //MessageBox.Show(googleSearch);

                        WebClient webClient = new WebClient();
                        String html = webClient.DownloadString(imdbSearch);
                        
                        MatchCollection m1 = Regex.Matches(html, "<td class=\"result_text\"> <a href=\"\\s*(.+?)\\s*\" >", RegexOptions.Singleline);

                        string[] foundSearches = new string[m1.Count];
                        for (int j = 0; j < m1.Count; j++)
                        {
                            foundSearches[j] = @"http://www.imdb.com" + m1[j].Groups[1].Value;

                            if (isIMDBPage(foundSearches[j]))
                            {
                                html = webClient.DownloadString(foundSearches[j]);
                                Movie newMovie = createMovieFromIMDB(html, allMoviesPaths[i]);

                                DataRow movieRow = dtMovies.NewRow();
                                movieRow["MovieName"] = newMovie.getName();
                                movieRow["ReleaseYear"] = newMovie.getReleaseYear();
                                movieRow["UserRating"] = -1;
                                movieRow["IMDBRating"] = newMovie.getIMDBRating();
                                movieRow["Path"] = newMovie.getFilepath();
                                movieRow["PicturePath"] = newMovie.getPicFilepath();
                                dtMovies.Rows.Add(movieRow);

                                //Thread.Sleep(1000);         // Wait some time so searches don't go too fast
                                break;
                            }
                        }
                    }
                }

                dtMovies.WriteXml(XMLlocation);         // Store movie data in XML
                getMovieDBData();                       // Populate MovieManager
                populateListView();                     // Populate ListView
            }
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
            ////for (int i = 0; i < dbMovies.Tables["Movies"].Rows.Count; i++)
            ////{
            ////    if (string.IsNullOrEmpty(dbMovies.Tables["Movies"].Rows[i]["ReleaseYear"].ToString()))
            ////    {
            ////        MessageBox.Show(dbMovies.Tables["Movies"].Rows[i]["MovieName"].ToString());
            ////    }
            ////}
            
            string name = "Prisoners";
            string html = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + "some.html");

            string picFilepath = "";
            var picFilepathStr = new Regex(name+" Poster\"\nsrc=\"(.*)\"\nitemprop").Match(html);

            MessageBox.Show("About to check");
            //MessageBox.Show("title=\"" + name + " Poster\"(.*)itemprop");
            if (picFilepathStr.Length > 0)
            {
                picFilepath = picFilepathStr.Groups[1].Value;
                MessageBox.Show(picFilepath);
            }

        }

        // Populate the MovieManager object with the movie data found in the database
        private void getMovieDBData()
        {
            movieManager.clearMovies();
            movieManager.clearFilteredMovies();
            for (int i = 0; i < dbMovies.Tables["Movies"].Rows.Count; i++)
            {
                Movie tempMovie = new Movie(dbMovies.Tables["Movies"].Rows[i]["MovieName"].ToString(),
                    Int32.Parse(dbMovies.Tables["Movies"].Rows[i]["ReleaseYear"].ToString()),
                    double.Parse(dbMovies.Tables["Movies"].Rows[i]["UserRating"].ToString()),
                    double.Parse(dbMovies.Tables["Movies"].Rows[i]["IMDBRating"].ToString()),
                    dbMovies.Tables["Movies"].Rows[i]["Path"].ToString(),
                    dbMovies.Tables["Movies"].Rows[i]["PicturePath"].ToString()
                    );
                movieManager.addMovie(tempMovie);
                movieManager.addFilteredMovie(tempMovie);
            }
        }

        // Populate ListView with Movie data
        private void populateListView()
        {
            MovieList.Items.Clear();
            for (int i=0; i<movieManager.getFilteredMovies().Count; i++)
            {
                ListViewItem lvi = new ListViewItem(movieManager.getFilteredMovies()[i].getName());
                lvi.SubItems.Add(movieManager.getFilteredMovies()[i].getReleaseYear().ToString());

                if(movieManager.getFilteredMovies()[i].getUserRating() != -1)
                {
                    lvi.SubItems.Add(movieManager.getFilteredMovies()[i].getUserRating().ToString());
                }
                else {
                    lvi.SubItems.Add("N/A");
                }

                if (movieManager.getFilteredMovies()[i].getIMDBRating() != -1)
                {
                    lvi.SubItems.Add(movieManager.getFilteredMovies()[i].getIMDBRating().ToString());
                }
                else
                {
                    lvi.SubItems.Add("N/A");
                }

                lvi.SubItems.Add(movieManager.getFilteredMovies()[i].getFilepath());
                lvi.SubItems.Add(movieManager.getFilteredMovies()[i].getPicFilepath());
                MovieList.Items.Add(lvi);
            }
        }


        // Returns a Movie object given a string for the html for an IMDB webpage of a movie
        private Movie createMovieFromIMDB(string html, string filepath)
        {
            File.WriteAllText(System.AppDomain.CurrentDomain.BaseDirectory + "some.html", html);
            WebClient webClient = new WebClient();

            // Find the movie name
            string name = "";
            MatchCollection m2 = Regex.Matches(html, "<div class=\"title_wrapper\">\\s*(.+?)\\s*<span id=\"titleYear\">", RegexOptions.Singleline);
            if(m2.Count > 0)
            {
                var nameStr = new Regex("<h1 itemprop=\"name\" class=\"\">(.*)&nbsp").Match(m2[0].Groups[1].Value);
                name = nameStr.Groups[1].Value;
            }

            // Find the movie release year
            int releaseYear = -1;
            var releaseYearStr = new Regex("<a href=\"/year/(.*)/\\?ref_=tt").Match(html);
            if(releaseYearStr.Length > 0)
            {
                releaseYear = Int32.Parse(releaseYearStr.Groups[1].Value);
            }

            // Find IMDB Rating
            double imdbRating = -1;
            var imdbRatingStr = new Regex("<span itemprop=\"ratingValue\">(.*)</span></strong>").Match(html);
            if(imdbRatingStr.Length > 0)
            {
                imdbRating = double.Parse(imdbRatingStr.Groups[1].Value);
            }

            // Find poster picture
            string picFilepath = "";
            var picFilepathStr = new Regex(name + " Poster\"\nsrc=\"(.*)\"\nitemprop").Match(html);
            if (picFilepathStr.Length > 0)
            {
                picFilepath = System.AppDomain.CurrentDomain.BaseDirectory + "poster_imgs/" + name + " Poster.jpg";
                webClient.DownloadFile(picFilepathStr.Groups[1].Value, picFilepath);
            }
            
            return new Movie(name, releaseYear, -1, imdbRating, filepath, picFilepath);
        }

        private bool isIMDBPage(string webPageLink)
        {
            var webPageName = new Regex("www\\.(.*)\\.").Match(webPageLink);
            //MessageBox.Show(webPageName.Groups[1].Value);
            if (webPageName.Groups[1].Value.Equals("imdb")){
                return true;
            }
            return false;
        }

        // All sorting button calls

        private void increasingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movieManager.sortMoviesAlphaIncr(0, movieManager.getFilteredMovies().Count - 1);
            populateListView();
        }

        private void decreasingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movieManager.sortMoviesAlphaDecr(0, movieManager.getFilteredMovies().Count - 1);
            populateListView();
        }

        private void increasingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            movieManager.sortMoviesReleaseYearIncr(0, movieManager.getFilteredMovies().Count - 1);
            populateListView();
        }

        private void decreasingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            movieManager.sortMoviesReleaseYearDecr(0, movieManager.getFilteredMovies().Count - 1);
            populateListView();
        }

        private void increasingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            movieManager.sortMoviesUserRatingIncr(0, movieManager.getFilteredMovies().Count - 1);
            populateListView();
        }

        private void decreasingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            movieManager.sortMoviesUserRatingDecr(0, movieManager.getFilteredMovies().Count - 1);
            populateListView();
        }

        private void increasingToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            movieManager.sortMoviesIMDBRatingIncr(0, movieManager.getFilteredMovies().Count - 1);
            populateListView();
        }

        private void decreasingToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            movieManager.sortMoviesIMDBRatingDecr(0, movieManager.getFilteredMovies().Count - 1);
            populateListView();
        }

        private void ResetSearchButton_Click(object sender, EventArgs e)
        {
            movieManager.clearFilteredMovies();
            movieManager.setFilteredMovies(movieManager.getMovies().ToList());
            populateListView();
            searchInputTextBox.Text = "";
        }
    }
}
