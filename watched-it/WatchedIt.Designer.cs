namespace watched_it
{
    partial class WatchedIt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WatchedIt));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.sortByMovieNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increasingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreasingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByMovieNameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.increasingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.decreasingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByUserRatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increasingToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.decreasingToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByIMDBRatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increasingToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.decreasingToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchInputTextBox = new System.Windows.Forms.TextBox();
            this.MovieList = new System.Windows.Forms.ListView();
            this.MovieColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReleaseYearColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserRatingColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IMDBRatingColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PathColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PicFilepathColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ResetSearchButton = new System.Windows.Forms.Button();
            this.movieDetailsPanel = new System.Windows.Forms.Panel();
            this.movieDetailsDescription = new System.Windows.Forms.Label();
            this.movieDetailsWatched = new System.Windows.Forms.Label();
            this.movieDetailsUserRating = new System.Windows.Forms.Label();
            this.movieDetailsIMDBRating = new System.Windows.Forms.Label();
            this.movieDetailsNameAndYear = new System.Windows.Forms.Label();
            this.movieDetailsPosterImg = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.movieDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieDetailsPosterImg)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1189, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(54, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridToolStripMenuItem,
            this.textListToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(61, 22);
            this.toolStripDropDownButton2.Text = "View";
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gridToolStripMenuItem.Image")));
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.gridToolStripMenuItem.Text = "Grid";
            this.gridToolStripMenuItem.Click += new System.EventHandler(this.gridToolStripMenuItem_Click);
            // 
            // textListToolStripMenuItem
            // 
            this.textListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("textListToolStripMenuItem.Image")));
            this.textListToolStripMenuItem.Name = "textListToolStripMenuItem";
            this.textListToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.textListToolStripMenuItem.Text = "Text List";
            this.textListToolStripMenuItem.Click += new System.EventHandler(this.textListToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByMovieNameToolStripMenuItem,
            this.sortByMovieNameToolStripMenuItem1,
            this.sortByUserRatingToolStripMenuItem,
            this.sortByIMDBRatingToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(57, 22);
            this.toolStripDropDownButton3.Text = "Sort";
            // 
            // sortByMovieNameToolStripMenuItem
            // 
            this.sortByMovieNameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.increasingToolStripMenuItem,
            this.decreasingToolStripMenuItem});
            this.sortByMovieNameToolStripMenuItem.Name = "sortByMovieNameToolStripMenuItem";
            this.sortByMovieNameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sortByMovieNameToolStripMenuItem.Text = "Sort by movie name";
            // 
            // increasingToolStripMenuItem
            // 
            this.increasingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("increasingToolStripMenuItem.Image")));
            this.increasingToolStripMenuItem.Name = "increasingToolStripMenuItem";
            this.increasingToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.increasingToolStripMenuItem.Text = "A->Z";
            this.increasingToolStripMenuItem.Click += new System.EventHandler(this.increasingToolStripMenuItem_Click);
            // 
            // decreasingToolStripMenuItem
            // 
            this.decreasingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("decreasingToolStripMenuItem.Image")));
            this.decreasingToolStripMenuItem.Name = "decreasingToolStripMenuItem";
            this.decreasingToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.decreasingToolStripMenuItem.Text = "Z->A";
            this.decreasingToolStripMenuItem.Click += new System.EventHandler(this.decreasingToolStripMenuItem_Click);
            // 
            // sortByMovieNameToolStripMenuItem1
            // 
            this.sortByMovieNameToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.increasingToolStripMenuItem1,
            this.decreasingToolStripMenuItem1});
            this.sortByMovieNameToolStripMenuItem1.Name = "sortByMovieNameToolStripMenuItem1";
            this.sortByMovieNameToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.sortByMovieNameToolStripMenuItem1.Text = "Sort by release year";
            // 
            // increasingToolStripMenuItem1
            // 
            this.increasingToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("increasingToolStripMenuItem1.Image")));
            this.increasingToolStripMenuItem1.Name = "increasingToolStripMenuItem1";
            this.increasingToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.increasingToolStripMenuItem1.Text = "Old->New";
            this.increasingToolStripMenuItem1.Click += new System.EventHandler(this.increasingToolStripMenuItem1_Click);
            // 
            // decreasingToolStripMenuItem1
            // 
            this.decreasingToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("decreasingToolStripMenuItem1.Image")));
            this.decreasingToolStripMenuItem1.Name = "decreasingToolStripMenuItem1";
            this.decreasingToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.decreasingToolStripMenuItem1.Text = "New->Old";
            this.decreasingToolStripMenuItem1.Click += new System.EventHandler(this.decreasingToolStripMenuItem1_Click);
            // 
            // sortByUserRatingToolStripMenuItem
            // 
            this.sortByUserRatingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.increasingToolStripMenuItem2,
            this.decreasingToolStripMenuItem2});
            this.sortByUserRatingToolStripMenuItem.Name = "sortByUserRatingToolStripMenuItem";
            this.sortByUserRatingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sortByUserRatingToolStripMenuItem.Text = "Sort by user rating";
            // 
            // increasingToolStripMenuItem2
            // 
            this.increasingToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("increasingToolStripMenuItem2.Image")));
            this.increasingToolStripMenuItem2.Name = "increasingToolStripMenuItem2";
            this.increasingToolStripMenuItem2.Size = new System.Drawing.Size(135, 22);
            this.increasingToolStripMenuItem2.Text = "Low->High";
            this.increasingToolStripMenuItem2.Click += new System.EventHandler(this.increasingToolStripMenuItem2_Click);
            // 
            // decreasingToolStripMenuItem2
            // 
            this.decreasingToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("decreasingToolStripMenuItem2.Image")));
            this.decreasingToolStripMenuItem2.Name = "decreasingToolStripMenuItem2";
            this.decreasingToolStripMenuItem2.Size = new System.Drawing.Size(135, 22);
            this.decreasingToolStripMenuItem2.Text = "High->Low";
            this.decreasingToolStripMenuItem2.Click += new System.EventHandler(this.decreasingToolStripMenuItem2_Click);
            // 
            // sortByIMDBRatingToolStripMenuItem
            // 
            this.sortByIMDBRatingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.increasingToolStripMenuItem3,
            this.decreasingToolStripMenuItem3});
            this.sortByIMDBRatingToolStripMenuItem.Name = "sortByIMDBRatingToolStripMenuItem";
            this.sortByIMDBRatingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sortByIMDBRatingToolStripMenuItem.Text = "Sort by IMDB rating";
            // 
            // increasingToolStripMenuItem3
            // 
            this.increasingToolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("increasingToolStripMenuItem3.Image")));
            this.increasingToolStripMenuItem3.Name = "increasingToolStripMenuItem3";
            this.increasingToolStripMenuItem3.Size = new System.Drawing.Size(135, 22);
            this.increasingToolStripMenuItem3.Text = "Low->High";
            this.increasingToolStripMenuItem3.Click += new System.EventHandler(this.increasingToolStripMenuItem3_Click);
            // 
            // decreasingToolStripMenuItem3
            // 
            this.decreasingToolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("decreasingToolStripMenuItem3.Image")));
            this.decreasingToolStripMenuItem3.Name = "decreasingToolStripMenuItem3";
            this.decreasingToolStripMenuItem3.Size = new System.Drawing.Size(135, 22);
            this.decreasingToolStripMenuItem3.Text = "High->Low";
            this.decreasingToolStripMenuItem3.Click += new System.EventHandler(this.decreasingToolStripMenuItem3_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(130, 22);
            this.toolStripButton1.Text = "Upload from Folder";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1021, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchInputTextBox
            // 
            this.searchInputTextBox.Location = new System.Drawing.Point(838, 5);
            this.searchInputTextBox.Name = "searchInputTextBox";
            this.searchInputTextBox.Size = new System.Drawing.Size(172, 20);
            this.searchInputTextBox.TabIndex = 3;
            this.searchInputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchInputTextBox_KeyDown);
            // 
            // MovieList
            // 
            this.MovieList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.MovieList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MovieColumn,
            this.ReleaseYearColumn,
            this.UserRatingColumn,
            this.IMDBRatingColumn,
            this.PathColumn,
            this.PicFilepathColumn});
            this.MovieList.FullRowSelect = true;
            this.MovieList.Location = new System.Drawing.Point(12, 39);
            this.MovieList.Name = "MovieList";
            this.MovieList.Size = new System.Drawing.Size(906, 573);
            this.MovieList.TabIndex = 4;
            this.MovieList.UseCompatibleStateImageBehavior = false;
            this.MovieList.ItemActivate += new System.EventHandler(this.MovieList_ItemActivate);
            this.MovieList.SelectedIndexChanged += new System.EventHandler(this.MovieList_SelectedIndexChanged);
            // 
            // MovieColumn
            // 
            this.MovieColumn.Text = "Movie";
            this.MovieColumn.Width = 199;
            // 
            // ReleaseYearColumn
            // 
            this.ReleaseYearColumn.Text = "Release Year";
            this.ReleaseYearColumn.Width = 93;
            // 
            // UserRatingColumn
            // 
            this.UserRatingColumn.Text = "User Rating";
            this.UserRatingColumn.Width = 82;
            // 
            // IMDBRatingColumn
            // 
            this.IMDBRatingColumn.Text = "IMDB Rating";
            this.IMDBRatingColumn.Width = 94;
            // 
            // PathColumn
            // 
            this.PathColumn.Text = "Path";
            this.PathColumn.Width = 233;
            // 
            // PicFilepathColumn
            // 
            this.PicFilepathColumn.Text = "Pic Path";
            this.PicFilepathColumn.Width = 187;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(935, 589);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1016, 589);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1102, 589);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ResetSearchButton
            // 
            this.ResetSearchButton.Location = new System.Drawing.Point(1102, 5);
            this.ResetSearchButton.Name = "ResetSearchButton";
            this.ResetSearchButton.Size = new System.Drawing.Size(75, 23);
            this.ResetSearchButton.TabIndex = 9;
            this.ResetSearchButton.Text = "Reset";
            this.ResetSearchButton.UseVisualStyleBackColor = true;
            this.ResetSearchButton.Click += new System.EventHandler(this.ResetSearchButton_Click);
            // 
            // movieDetailsPanel
            // 
            this.movieDetailsPanel.BackColor = System.Drawing.SystemColors.Window;
            this.movieDetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.movieDetailsPanel.Controls.Add(this.movieDetailsDescription);
            this.movieDetailsPanel.Controls.Add(this.movieDetailsWatched);
            this.movieDetailsPanel.Controls.Add(this.movieDetailsUserRating);
            this.movieDetailsPanel.Controls.Add(this.movieDetailsIMDBRating);
            this.movieDetailsPanel.Controls.Add(this.movieDetailsNameAndYear);
            this.movieDetailsPanel.Controls.Add(this.movieDetailsPosterImg);
            this.movieDetailsPanel.Location = new System.Drawing.Point(935, 39);
            this.movieDetailsPanel.Name = "movieDetailsPanel";
            this.movieDetailsPanel.Size = new System.Drawing.Size(242, 544);
            this.movieDetailsPanel.TabIndex = 10;
            // 
            // movieDetailsDescription
            // 
            this.movieDetailsDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieDetailsDescription.Location = new System.Drawing.Point(14, 370);
            this.movieDetailsDescription.Name = "movieDetailsDescription";
            this.movieDetailsDescription.Size = new System.Drawing.Size(209, 89);
            this.movieDetailsDescription.TabIndex = 5;
            this.movieDetailsDescription.Text = "Description";
            // 
            // movieDetailsWatched
            // 
            this.movieDetailsWatched.AutoSize = true;
            this.movieDetailsWatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieDetailsWatched.Location = new System.Drawing.Point(14, 497);
            this.movieDetailsWatched.Name = "movieDetailsWatched";
            this.movieDetailsWatched.Size = new System.Drawing.Size(68, 17);
            this.movieDetailsWatched.TabIndex = 4;
            this.movieDetailsWatched.Text = "Watched:";
            // 
            // movieDetailsUserRating
            // 
            this.movieDetailsUserRating.AutoSize = true;
            this.movieDetailsUserRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieDetailsUserRating.Location = new System.Drawing.Point(14, 480);
            this.movieDetailsUserRating.Name = "movieDetailsUserRating";
            this.movieDetailsUserRating.Size = new System.Drawing.Size(91, 17);
            this.movieDetailsUserRating.TabIndex = 3;
            this.movieDetailsUserRating.Text = "User Rating: ";
            // 
            // movieDetailsIMDBRating
            // 
            this.movieDetailsIMDBRating.AutoSize = true;
            this.movieDetailsIMDBRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieDetailsIMDBRating.Location = new System.Drawing.Point(14, 463);
            this.movieDetailsIMDBRating.Name = "movieDetailsIMDBRating";
            this.movieDetailsIMDBRating.Size = new System.Drawing.Size(94, 17);
            this.movieDetailsIMDBRating.TabIndex = 2;
            this.movieDetailsIMDBRating.Text = "IMDB Rating: ";
            // 
            // movieDetailsNameAndYear
            // 
            this.movieDetailsNameAndYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieDetailsNameAndYear.Location = new System.Drawing.Point(13, 287);
            this.movieDetailsNameAndYear.Name = "movieDetailsNameAndYear";
            this.movieDetailsNameAndYear.Size = new System.Drawing.Size(213, 83);
            this.movieDetailsNameAndYear.TabIndex = 1;
            this.movieDetailsNameAndYear.Text = "Movie Name (Year)";
            // 
            // movieDetailsPosterImg
            // 
            this.movieDetailsPosterImg.BackColor = System.Drawing.SystemColors.Window;
            this.movieDetailsPosterImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.movieDetailsPosterImg.Location = new System.Drawing.Point(17, 14);
            this.movieDetailsPosterImg.Name = "movieDetailsPosterImg";
            this.movieDetailsPosterImg.Size = new System.Drawing.Size(174, 259);
            this.movieDetailsPosterImg.TabIndex = 0;
            this.movieDetailsPosterImg.TabStop = false;
            // 
            // WatchedIt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1189, 624);
            this.Controls.Add(this.movieDetailsPanel);
            this.Controls.Add(this.ResetSearchButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MovieList);
            this.Controls.Add(this.searchInputTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.toolStrip1);
            this.Name = "WatchedIt";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Watched It";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.movieDetailsPanel.ResumeLayout(false);
            this.movieDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieDetailsPosterImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchInputTextBox;
        private System.Windows.Forms.ListView MovieList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader MovieColumn;
        private System.Windows.Forms.ColumnHeader PathColumn;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textListToolStripMenuItem;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader ReleaseYearColumn;
        private System.Windows.Forms.ColumnHeader UserRatingColumn;
        private System.Windows.Forms.ColumnHeader IMDBRatingColumn;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem sortByMovieNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increasingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreasingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByMovieNameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem increasingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem decreasingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sortByUserRatingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increasingToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem decreasingToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sortByIMDBRatingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increasingToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem decreasingToolStripMenuItem3;
        private System.Windows.Forms.Button ResetSearchButton;
        private System.Windows.Forms.ColumnHeader PicFilepathColumn;
        private System.Windows.Forms.Panel movieDetailsPanel;
        private System.Windows.Forms.PictureBox movieDetailsPosterImg;
        private System.Windows.Forms.Label movieDetailsUserRating;
        private System.Windows.Forms.Label movieDetailsIMDBRating;
        private System.Windows.Forms.Label movieDetailsNameAndYear;
        private System.Windows.Forms.Label movieDetailsWatched;
        private System.Windows.Forms.Label movieDetailsDescription;
    }
}

