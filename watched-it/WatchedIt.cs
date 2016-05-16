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
        //MovieManager movieManager = new MovieManager();

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

                MovieList.SmallImageList = null;
                MovieList.LargeImageList = null;
                MovieList.View = View.Details;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        // Filters the movies shown in the ListView dependant on the input search text
        private void searchButton_Click(object sender, EventArgs e)
        {
            MovieManager.getInstance().clearFilteredMovies();
            for(int i=0; i< MovieManager.getInstance().getMovies().Count; i++)
            {
                if (MovieManager.getInstance().getMovies()[i].getName().ToLower().Contains(searchInputTextBox.Text.ToLower()))
                {
                    MovieManager.getInstance().addFilteredMovie(MovieManager.getInstance().getMovies()[i]);
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
                                movieRow["Watched"] = newMovie.getWatched();
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

                MovieList.SmallImageList = null;
                MovieList.LargeImageList = null;
                MovieList.View = View.Details;
            }

        }

        private void MovieList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //imgList.ImageSize = new Size(100, 100);

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

            EditMovie editMovie = new EditMovie(this, dbMovies);

            if (MovieList.SelectedItems.Count == 1)
            {
                editMovie.setSelectedMovie(MovieManager.getInstance().getMovieByNameAndRelease(
                    MovieList.SelectedItems[0].SubItems[0].Text,
                    Int32.Parse(MovieList.SelectedItems[0].SubItems[1].Text)));
                editMovie.Show();
            }

        }

        // Display the movies in standard image grid form
        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieList.LargeImageList = imgList;
            MovieList.View = View.LargeIcon;
        }

        // Display the movies using a basic text list format
        private void textListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieList.SmallImageList = null;
            MovieList.LargeImageList = null;
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

            //string name = "Prisoners";
            //string html = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + "some.html");

            //string picFilepath = "";
            //var picFilepathStr = new Regex(name+" Poster\"\nsrc=\"(.*)\"\nitemprop").Match(html);

            //MessageBox.Show("About to check");
            ////MessageBox.Show("title=\"" + name + " Poster\"(.*)itemprop");
            //if (picFilepathStr.Length > 0)
            //{
            //    picFilepath = picFilepathStr.Groups[1].Value;
            //    MessageBox.Show(picFilepath);
            //}



            //DataRow[] movieRow = dbMovies.Tables["Movies"].Select("MovieName = 'Good Will Hunting' AND ReleaseYear = '1998'");

            //MessageBox.Show(movieRow[0]["Path"].ToString());


            MovieList.Items.Clear();
            imgList.ImageSize = new Size(100, 150);

            string imgPath = System.AppDomain.CurrentDomain.BaseDirectory + "poster_imgs";
            string[] images = System.IO.Directory.GetFiles(@imgPath, "*.jpg", System.IO.SearchOption.AllDirectories);

            // Store all images from the imgs directory to the images array
            for (int i = 0; i < images.Length; i++)
            {
                imgList.Images.Add(Image.FromFile(images[i]));
            }

            //// Put all images from image array to ListView
            //for (int j = 0; j < images.Length; j++)
            //{
            //    ListViewItem lvi = new ListViewItem();
            //    lvi.ImageIndex = j;
            //    MovieList.Items.Add(lvi);
            //}

            // Set the image lists for the ListView
            MovieList.SmallImageList = imgList;
            MovieList.LargeImageList = imgList;
            ListViewItem lvi = new ListViewItem("some name ok");
            lvi.ImageIndex = 0;
            lvi.SubItems.Add("some name");
            lvi.SubItems.Add("some release");
            MovieList.Items.Add(lvi);

        }

        // Populate the MovieManager object with the movie data found in the database
        private void getMovieDBData()
        {
            MovieManager.getInstance().clearMovies();
            MovieManager.getInstance().clearFilteredMovies();
            for (int i = 0; i < dbMovies.Tables["Movies"].Rows.Count; i++)
            {

                Movie tempMovie = new Movie(dbMovies.Tables["Movies"].Rows[i]["MovieName"].ToString(),
                    Int32.Parse(dbMovies.Tables["Movies"].Rows[i]["ReleaseYear"].ToString()),
                    double.Parse(dbMovies.Tables["Movies"].Rows[i]["UserRating"].ToString()),
                    double.Parse(dbMovies.Tables["Movies"].Rows[i]["IMDBRating"].ToString()),
                    dbMovies.Tables["Movies"].Rows[i]["Path"].ToString(),
                    dbMovies.Tables["Movies"].Rows[i]["PicturePath"].ToString(),
                    Boolean.Parse(dbMovies.Tables["Movies"].Rows[i]["Watched"].ToString())
                    );
                MovieManager.getInstance().addMovie(tempMovie);
                MovieManager.getInstance().addFilteredMovie(tempMovie);
                imgList.Images.Add(Image.FromFile(dbMovies.Tables["Movies"].Rows[i]["PicturePath"].ToString()));
            }
        }

        // Populate ListView with Movie data
        private void populateListView()
        {
            MovieList.Items.Clear();
            imgList.ImageSize = new Size(100, 150);
            MovieList.SmallImageList = imgList;
            MovieList.LargeImageList = imgList;
            for (int i=0; i< MovieManager.getInstance().getFilteredMovies().Count; i++)
            {
                ListViewItem lvi = new ListViewItem(MovieManager.getInstance().getFilteredMovies()[i].getName());
                lvi.SubItems.Add(MovieManager.getInstance().getFilteredMovies()[i].getReleaseYear().ToString());

                if(MovieManager.getInstance().getFilteredMovies()[i].getUserRating() != -1)
                {
                    lvi.SubItems.Add(MovieManager.getInstance().getFilteredMovies()[i].getUserRating().ToString());
                }
                else {
                    lvi.SubItems.Add("N/A");
                }

                if (MovieManager.getInstance().getFilteredMovies()[i].getIMDBRating() != -1)
                {
                    lvi.SubItems.Add(MovieManager.getInstance().getFilteredMovies()[i].getIMDBRating().ToString());
                }
                else
                {
                    lvi.SubItems.Add("N/A");
                }

                lvi.SubItems.Add(MovieManager.getInstance().getFilteredMovies()[i].getFilepath());
                lvi.SubItems.Add(MovieManager.getInstance().getFilteredMovies()[i].getPicFilepath());
                lvi.ImageIndex = i;
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
                try
                {
                    picFilepath = System.AppDomain.CurrentDomain.BaseDirectory + "poster_imgs/" + validFileStr(name) + " Poster.jpg";
                    webClient.DownloadFile(picFilepathStr.Groups[1].Value, picFilepath);
                    imgList.Images.Add(Image.FromFile(picFilepath));
                } catch(Exception e)
                {
                    // Use generic default image for the poster image
                    picFilepath = System.AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\imgs\\img_not_found.png"; ;
                    imgList.Images.Add(Image.FromFile(picFilepath));
                }
            } else
            {
                // Use generic default image for the poster image
                picFilepath = System.AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\imgs\\img_not_found.png"; ;
                imgList.Images.Add(Image.FromFile(picFilepath));
            }
            
            return new Movie(name, releaseYear, -1, imdbRating, filepath, picFilepath, false);
        }

        private string validFileStr(string name)
        {
            name = name.Replace("\\", "");
            name = name.Replace("/", "");
            name = name.Replace(":", "");
            name = name.Replace("*", "");
            name = name.Replace("?", "");
            name = name.Replace("<", "");
            name = name.Replace(">", "");
            name = name.Replace("|", "");
            name = name.Replace(".", "");
            name = name.Replace(",", "");

            return name;
        }

        private bool isIMDBPage(string webPageLink)
        {
            var webPageName = new Regex("www\\.(.*)\\.").Match(webPageLink);
            if (webPageName.Groups[1].Value.Equals("imdb")){
                return true;
            }
            return false;
        }

        // All sorting button calls

        private void increasingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieManager.getInstance().sortMoviesAlphaIncr(0, MovieManager.getInstance().getFilteredMovies().Count - 1);
            populateListView();
        }

        private void decreasingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieManager.getInstance().sortMoviesAlphaDecr(0, MovieManager.getInstance().getFilteredMovies().Count - 1);
            populateListView();
        }

        private void increasingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MovieManager.getInstance().sortMoviesReleaseYearIncr(0, MovieManager.getInstance().getFilteredMovies().Count - 1);
            populateListView();
        }

        private void decreasingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MovieManager.getInstance().sortMoviesReleaseYearDecr(0, MovieManager.getInstance().getFilteredMovies().Count - 1);
            populateListView();
        }

        private void increasingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MovieManager.getInstance().sortMoviesUserRatingIncr(0, MovieManager.getInstance().getFilteredMovies().Count - 1);
            populateListView();
        }

        private void decreasingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MovieManager.getInstance().sortMoviesUserRatingDecr(0, MovieManager.getInstance().getFilteredMovies().Count - 1);
            populateListView();
        }

        private void increasingToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MovieManager.getInstance().sortMoviesIMDBRatingIncr(0, MovieManager.getInstance().getFilteredMovies().Count - 1);
            populateListView();
        }

        private void decreasingToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MovieManager.getInstance().sortMoviesIMDBRatingDecr(0, MovieManager.getInstance().getFilteredMovies().Count - 1);
            populateListView();
        }

        private void ResetSearchButton_Click(object sender, EventArgs e)
        {
            MovieManager.getInstance().clearFilteredMovies();
            MovieManager.getInstance().setFilteredMovies(MovieManager.getInstance().getMovies().ToList());
            populateListView();
            searchInputTextBox.Text = "";
        }

        public void updateList()
        {
            MovieManager.getInstance().clearFilteredMovies();
            MovieManager.getInstance().setFilteredMovies(MovieManager.getInstance().getMovies().ToList());
            populateListView();
            searchInputTextBox.Text = "";
        }
    }
}
