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
            this.imageListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.MovieList = new System.Windows.Forms.ListView();
            this.MovieColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PathColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.someIMGList = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1017, 25);
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridToolStripMenuItem,
            this.imageListToolStripMenuItem,
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
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.gridToolStripMenuItem.Text = "Grid";
            // 
            // imageListToolStripMenuItem
            // 
            this.imageListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imageListToolStripMenuItem.Image")));
            this.imageListToolStripMenuItem.Name = "imageListToolStripMenuItem";
            this.imageListToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.imageListToolStripMenuItem.Text = "Image List";
            // 
            // textListToolStripMenuItem
            // 
            this.textListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("textListToolStripMenuItem.Image")));
            this.textListToolStripMenuItem.Name = "textListToolStripMenuItem";
            this.textListToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.textListToolStripMenuItem.Text = "Text List";
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
            this.searchButton.Location = new System.Drawing.Point(930, 6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(752, 8);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(172, 20);
            this.searchInput.TabIndex = 3;
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
            // 
            // MovieList
            // 
            this.MovieList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MovieColumn,
            this.PathColumn});
            this.MovieList.FullRowSelect = true;
            this.MovieList.Location = new System.Drawing.Point(22, 39);
            this.MovieList.Name = "MovieList";
            this.MovieList.Size = new System.Drawing.Size(702, 483);
            this.MovieList.TabIndex = 4;
            this.MovieList.UseCompatibleStateImageBehavior = false;
            this.MovieList.View = System.Windows.Forms.View.Details;
            this.MovieList.SelectedIndexChanged += new System.EventHandler(this.MovieList_SelectedIndexChanged);
            // 
            // MovieColumn
            // 
            this.MovieColumn.Text = "Movie";
            this.MovieColumn.Width = 218;
            // 
            // PathColumn
            // 
            this.PathColumn.Text = "Path";
            this.PathColumn.Width = 404;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(771, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // someIMGList
            // 
            this.someIMGList.Location = new System.Drawing.Point(752, 88);
            this.someIMGList.Name = "someIMGList";
            this.someIMGList.Size = new System.Drawing.Size(253, 434);
            this.someIMGList.TabIndex = 6;
            this.someIMGList.UseCompatibleStateImageBehavior = false;
            this.someIMGList.View = System.Windows.Forms.View.SmallIcon;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(892, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WatchedIt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.someIMGList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MovieList);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.toolStrip1);
            this.Name = "WatchedIt";
            this.Text = "Watched It";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.ListView MovieList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader MovieColumn;
        private System.Windows.Forms.ColumnHeader PathColumn;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textListToolStripMenuItem;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ListView someIMGList;
        private System.Windows.Forms.Button button2;
    }
}

