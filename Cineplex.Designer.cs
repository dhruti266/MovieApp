namespace MovieFinalProject
{
    partial class Cineplex
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
            this.movieDataGrid = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.moviePoster = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.comboBoxDAY = new System.Windows.Forms.ComboBox();
            this.showTime = new System.Windows.Forms.Label();
            this.lblShowsTime = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // movieDataGrid
            // 
            this.movieDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.movieDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.movieDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.movieDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.movieDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieDataGrid.Location = new System.Drawing.Point(12, 64);
            this.movieDataGrid.MultiSelect = false;
            this.movieDataGrid.Name = "movieDataGrid";
            this.movieDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.movieDataGrid.Size = new System.Drawing.Size(699, 182);
            this.movieDataGrid.TabIndex = 0;
            this.movieDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onMovieClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(636, 252);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(555, 252);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblMessage.Location = new System.Drawing.Point(241, 19);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(212, 31);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "Cineplex Movies";
            // 
            // moviePoster
            // 
            this.moviePoster.Location = new System.Drawing.Point(13, 297);
            this.moviePoster.Name = "moviePoster";
            this.moviePoster.Size = new System.Drawing.Size(165, 207);
            this.moviePoster.TabIndex = 6;
            this.moviePoster.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTitle.Location = new System.Drawing.Point(198, 297);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 25);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Title";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseDate.ForeColor = System.Drawing.Color.Black;
            this.lblReleaseDate.Location = new System.Drawing.Point(202, 375);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(94, 15);
            this.lblReleaseDate.TabIndex = 8;
            this.lblReleaseDate.Text = "Release Date";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.Black;
            this.lblGenre.Location = new System.Drawing.Point(202, 322);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(47, 13);
            this.lblGenre.TabIndex = 9;
            this.lblGenre.Text = "Genres";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.ForeColor = System.Drawing.Color.Black;
            this.lblDirector.Location = new System.Drawing.Point(202, 350);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(58, 15);
            this.lblDirector.TabIndex = 10;
            this.lblDirector.Text = "Director";
            // 
            // lblShowTime
            // 
            this.lblShowTime.AutoSize = true;
            this.lblShowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblShowTime.ForeColor = System.Drawing.Color.Black;
            this.lblShowTime.Location = new System.Drawing.Point(202, 402);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(91, 15);
            this.lblShowTime.TabIndex = 26;
            this.lblShowTime.Text = "Choose Day: ";
            // 
            // comboBoxDAY
            // 
            this.comboBoxDAY.DropDownHeight = 60;
            this.comboBoxDAY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDAY.ForeColor = System.Drawing.Color.Teal;
            this.comboBoxDAY.FormattingEnabled = true;
            this.comboBoxDAY.IntegralHeight = false;
            this.comboBoxDAY.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.comboBoxDAY.Location = new System.Drawing.Point(297, 402);
            this.comboBoxDAY.Name = "comboBoxDAY";
            this.comboBoxDAY.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDAY.TabIndex = 25;
            this.comboBoxDAY.SelectedIndexChanged += new System.EventHandler(this.comboBoxDAY_SelectedIndexChanged);
            // 
            // showTime
            // 
            this.showTime.AutoSize = true;
            this.showTime.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.showTime.Location = new System.Drawing.Point(424, 402);
            this.showTime.Name = "showTime";
            this.showTime.Size = new System.Drawing.Size(60, 16);
            this.showTime.TabIndex = 27;
            this.showTime.Text = "showTime";
            // 
            // lblShowsTime
            // 
            this.lblShowsTime.AutoSize = true;
            this.lblShowsTime.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowsTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblShowsTime.Location = new System.Drawing.Point(294, 460);
            this.lblShowsTime.Name = "lblShowsTime";
            this.lblShowsTime.Size = new System.Drawing.Size(0, 15);
            this.lblShowsTime.TabIndex = 28;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(408, 252);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(141, 23);
            this.btnUpload.TabIndex = 29;
            this.btnUpload.Text = "Upload Poster";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // Cineplex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(723, 529);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblShowsTime);
            this.Controls.Add(this.showTime);
            this.Controls.Add(this.lblShowTime);
            this.Controls.Add(this.comboBoxDAY);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.moviePoster);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.movieDataGrid);
            this.Name = "Cineplex";
            this.Text = "Cineplex Movies";
            this.Load += new System.EventHandler(this.Cineplex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviePoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView movieDataGrid;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox moviePoster;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblShowTime;
        private System.Windows.Forms.ComboBox comboBoxDAY;
        private System.Windows.Forms.Label showTime;
        private System.Windows.Forms.Label lblShowsTime;
        private System.Windows.Forms.Button btnUpload;
    }
}

