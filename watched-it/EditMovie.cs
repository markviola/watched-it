using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace watched_it
{
    public partial class EditMovie : Form
    {
        WatchedIt MainForm;
        MovieDB dbMovies;

        Movie SelectedMovie;
        String XMLlocation = Application.StartupPath + @"\XMLMovies.xml";

        public EditMovie(WatchedIt mainForm, MovieDB DBMovies)
        {
            InitializeComponent();
            MainForm = mainForm;
            dbMovies = DBMovies;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var checkedButton = UserRatingGroupBox.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            
            // Edit user rating of the movie
            if (checkedButton != null)
            {
                updateDB(NameTextBox.Text, Int32.Parse(ReleaseYearTextBox.Text), 
                    Int32.Parse(checkedButton.Name.Replace("UserRatingRadioButton", "")), WatchedRadioButtonYes.Checked);
                MovieManager.getInstance().setMovieUserRating(SelectedMovie.getName(),
                    Int32.Parse(checkedButton.Name.Replace("UserRatingRadioButton", "")));
            }
            else
            {
                updateDB(NameTextBox.Text, Int32.Parse(ReleaseYearTextBox.Text), -1, WatchedRadioButtonYes.Checked);
            }

            // Edit movie name
            MovieManager.getInstance().setMovieName(SelectedMovie.getName(), NameTextBox.Text);

            // Edit movie release date
            MovieManager.getInstance().setMovieReleaseYear(SelectedMovie.getName(),
                Int32.Parse(ReleaseYearTextBox.Text));

            // Edit if movie has been watched
            if (WatchedRadioButtonYes.Checked)
            {
                MovieManager.getInstance().setMovieWatched(SelectedMovie.getName(), true);
            }
            else
            {
                MovieManager.getInstance().setMovieWatched(SelectedMovie.getName(), false);
            }

            MainForm.updateList();
            Close();
        }

        public void setSelectedMovie(Movie selectedMovie)
        {
            SelectedMovie = selectedMovie;

            // Populate movie name and release date
            NameTextBox.Text = SelectedMovie.getName();
            ReleaseYearTextBox.Text = SelectedMovie.getReleaseYear().ToString();
            
            // Populate user rating
            if(SelectedMovie.getUserRating() != -1)
            {
                int userRating = Convert.ToInt32(SelectedMovie.getUserRating());
                switch (userRating)
                {
                    case 1:
                        UserRatingRadioButton1.Checked = true;
                        break;
                    case 2:
                        UserRatingRadioButton2.Checked = true;
                        break;
                    case 3:
                        UserRatingRadioButton3.Checked = true;
                        break;
                    case 4:
                        UserRatingRadioButton4.Checked = true;
                        break;
                    case 5:
                        UserRatingRadioButton5.Checked = true;
                        break;
                    case 6:
                        UserRatingRadioButton6.Checked = true;
                        break;
                    case 7:
                        UserRatingRadioButton7.Checked = true;
                        break;
                    case 8:
                        UserRatingRadioButton8.Checked = true;
                        break;
                    case 9:
                        UserRatingRadioButton9.Checked = true;
                        break;
                    case 10:
                        UserRatingRadioButton10.Checked = true;
                        break;
                }
            }

            // Populate if movie watched
            if (SelectedMovie.getWatched())
            {
                WatchedRadioButtonYes.Checked = true;
            } 
            else
            {
                WatchedRadioButtonNo.Checked = true;
            }
        }

        // Update the XML file with the new, editted data
        private void updateDB(string newName, int newReleaseYear, double newUserRating, Boolean newWatched)
        {
            DataRow[] movieRow = dbMovies.Tables["Movies"].Select(
                "MovieName = '"+ SelectedMovie.getName() + "' AND ReleaseYear = '" + 
                SelectedMovie.getReleaseYear() + "'");
                        
            movieRow[0]["MovieName"] = newName;
            movieRow[0]["ReleaseYear"] = newReleaseYear;
            movieRow[0]["Watched"] = newWatched;
            if(newUserRating != -1)
            {
                movieRow[0]["UserRating"] = newUserRating;
            }
            
            dbMovies.Tables["Movies"].WriteXml(XMLlocation);
        }

    }
}
