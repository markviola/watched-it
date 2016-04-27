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
        string[] allMovies;
        string[] allMoviesPaths;
        ImageList imgList = new ImageList();

        public WatchedIt()
        {
            InitializeComponent();
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(searchInput.Text);
            string searchText = searchInput.Text;
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Movie newMovie = new Movie("Movie 1", 2011, "E:\\Movies\\2 Guns [2013]\\2 Guns [2013].mp4");
            //Process.Start(@newMovie.getFilepath());

            for(int i=0; i<MovieList.SelectedItems.Count; i++)
            {
                Process.Start(@MovieList.SelectedItems[i].SubItems[1].Text);
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            // Prompt User for directory path for movie lists
            // Note: Each movie must be in a subdirectory of this selected directory
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            allMovies = System.IO.Directory.GetDirectories(@fbd.SelectedPath, "*", System.IO.SearchOption.AllDirectories);

            allMoviesPaths = new string[allMovies.Length];
            for(int k=0; k<allMoviesPaths.Length; k++) { allMoviesPaths[k] = ""; }

            for(int i=0; i<allMovies.Length; i++)
            {
                // Get .mkv, .mp4, and .avi files
                string[] mkvFiles = System.IO.Directory.GetFiles(allMovies[i], "*.mkv", System.IO.SearchOption.AllDirectories);
                string[] mp4Files = System.IO.Directory.GetFiles(allMovies[i], "*.mp4", System.IO.SearchOption.AllDirectories);
                string[] aviFiles = System.IO.Directory.GetFiles(allMovies[i], "*.avi", System.IO.SearchOption.AllDirectories);
                if(mkvFiles.Length > 0)
                {
                    mkvFiles.CopyTo(allMoviesPaths, i);
                } else if (mp4Files.Length > 0)
                {
                    mp4Files.CopyTo(allMoviesPaths, i);
                } else if (aviFiles.Length > 0)
                {
                    aviFiles.CopyTo(allMoviesPaths, i);
                }

                if (!allMoviesPaths[i].Equals(""))
                {
                    string movieName = allMoviesPaths[i].Substring(allMovies[i].Length + 1);
                    ListViewItem lvi = new ListViewItem(movieName);
                    lvi.SubItems.Add(allMoviesPaths[i]);
                    MovieList.Items.Add(lvi);
                }
            }
        }

        private void MovieList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] images = System.IO.Directory.GetFiles(@"C:\Users\Mark\Desktop\Projects\watched-it\imgs\", "*.png", System.IO.SearchOption.AllDirectories);
            for (int i = 0; i < images.Length; i++)
            {
                //MessageBox.Show(images[i]);
                imgList.Images.Add(i.ToString(), Image.FromFile(images[i]));
            }

            someIMGList.SmallImageList = imgList;

            for (int j=0; j<images.Length; j++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add("A");
                lvi.ImageIndex = j;
                someIMGList.Items.Add(lvi);
            }
        }
    }
}
