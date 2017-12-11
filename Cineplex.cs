using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieFinalProject
{
    public partial class Cineplex : Form
    {
        private OleDbDataAdapter movieDataAdap;
        private DataSet movieDS;
        private OleDbCommandBuilder cBuilder;
        private OleDbConnection dbConn;
        private OleDbCommand dbCmd;

        public Cineplex()
        {
            InitializeComponent();
        }

        private void Cineplex_Load(object sender, EventArgs e)
        {
            dbConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Movie_Cast_DB.accdb");
            dbConn.Open();

            this.loadMovies(sender, e);
            this.hideMovieLabels();
            this.loadMovieLables(sender, 0);
        }

        private void hideMovieLabels()
        {
            showTime.Visible = false;
            lblTitle.Visible = false;
            lblGenre.Visible = false;
            lblDirector.Visible = false;
            lblShowTime.Visible = false;
            lblShowsTime.Visible = false;
            lblReleaseDate.Visible = false;
            comboBoxDAY.Visible = false;
            moviePoster.Image = null;
            btnDelete.Visible = false;
            btnUpload.Visible = false;
            btnUpdate.Visible = true;
        }

        private void loadMovieLables(object sender, int i)
        {
            if (movieDataGrid.SelectedRows[0].Cells[i].Value.ToString() != "")
            {
                lblTitle.Visible = true;
                lblGenre.Visible = true;
                lblDirector.Visible = true;
                lblShowTime.Visible = true;
                lblReleaseDate.Visible = true;
                comboBoxDAY.Visible = true;
                btnDelete.Visible = true;
                btnUpload.Visible = true;

                String dateTxt = movieDataGrid.Rows[i].Cells[3].Value.ToString();
                DateTime dt = Convert.ToDateTime(dateTxt);

                lblReleaseDate.Text = dt.Date.ToShortDateString();
                lblTitle.Text = movieDataGrid.Rows[i].Cells[1].Value.ToString();
                lblGenre.Text = movieDataGrid.Rows[i].Cells[2].Value.ToString();
                lblDirector.Text = movieDataGrid.Rows[i].Cells[4].Value.ToString();
                lblShowsTime.Text = movieDataGrid.Rows[i].Cells[5].Value.ToString();

                moviePoster.Image  = null;
                string imagePath   = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                string picturePath = movieDataGrid.Rows[i].Cells[6].Value.ToString();

                if (picturePath != "")
                {
                    imagePath += picturePath;
                    moviePoster.Image = Image.FromFile(@imagePath);
                    moviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    @imagePath += "\\Resources\\no_poster.png";
                    moviePoster.Image = Image.FromFile(@imagePath);
                    moviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else
            {
                this.hideMovieLabels();
            }
        }

        private void loadMovies(object sender, EventArgs e)
        {
            try
            {
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                btnUpload.Visible = true;

                // Construct an object of the OleDbConnection
                // class to store the connection string
                // representing the type of data provider
                // (database) and the source (actual db)
                // Construct an object of the OleDbCommand
                // class to hold the SQL query. 
                dbCmd = new OleDbCommand();
                dbCmd.CommandText = "SELECT * FROM movie_information;";

                // Tie the OleDbCommand object to the OleDbConnection object
                dbCmd.Connection = dbConn;

                movieDataAdap = new OleDbDataAdapter();
                movieDataAdap.SelectCommand = dbCmd;
                movieDS = new DataSet();
                movieDataAdap.Fill(movieDS, "movie_information");
                movieDataGrid.DataSource = movieDS;
                movieDataGrid.DataMember = "movie_information";
                movieDataGrid.Columns[6].Visible = false;

                if (Convert.ToBoolean(movieDataGrid.SelectedRows[0].Cells[0].Value) == true)
                {
                    btnUpdate.Visible = true;
                    btnDelete.Visible = true;
                    btnUpload.Visible = true;
                }
            }
            catch (System.Exception exc)
            {
                lblMessage.Text = exc.Message;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.movieDataGrid.SelectedRows.Count == 1)
            {
                try
                {
                    if (Convert.ToBoolean(movieDataGrid.SelectedRows[0].Cells[0].Value) == true)
                    {
                        String selectedMovie = this.movieDataGrid.SelectedRows[0].Cells[0].Value.ToString();
                        dbCmd.CommandText = "DELETE FROM movie_information WHERE movieId=" + selectedMovie;
                        dbCmd.ExecuteNonQuery();
                        this.loadMovies(sender, e);
                        this.lblMessage.Text = "Movie deleted successfully!!";
                    }
                    else
                    {
                        MessageBox.Show("There is no data to delete on selected row.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Select the row to delete.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cBuilder = new OleDbCommandBuilder(movieDataAdap);
                movieDataAdap.Update(movieDS, "movie_information");
                lblMessage.Text = "Movie is updated successfully....";
            }
            catch (System.Exception exc)
            {
                this.lblMessage.Text = exc.Message;
            }
        }

        private void onMovieClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this.hideMovieLabels();
                this.loadMovieLables(sender, e.RowIndex);
            }
        }

        private void comboBoxDAY_SelectedIndexChanged(object sender, EventArgs e)
        {
             string[] shows = lblShowsTime.Text.Split(',');

             showTime.Visible = true;
             if(comboBoxDAY.SelectedIndex < shows.Length) {
                showTime.Text = shows[comboBoxDAY.SelectedIndex];
             }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (this.movieDataGrid.SelectedRows.Count == 1)
            {
                OpenFileDialog op = new OpenFileDialog();
                op.ShowDialog();
                op.Filter = "allfiles|*.png|*.jpg|*.jpeg";

                string[] FName;
                string imagePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

                if (Convert.ToBoolean(movieDataGrid.SelectedRows[0].Cells[0].Value) == true)
                {
                    string selectedMovieID = movieDataGrid.SelectedRows[0].Cells[0].Value.ToString();

                    foreach (string s in op.FileNames)
                    {
                        try
                        {
                            FName = s.Split('\\');
                            string targetURL = "\\Resources\\" + FName[FName.Length - 1];
                            imagePath += targetURL;

                            if (File.Exists(@imagePath))
                            {
                                File.Delete(@imagePath);
                            }

                            File.Copy(s, imagePath, true);
                            dbCmd.CommandText = "UPDATE movie_information SET posturePath = '" + targetURL + "' WHERE movieId=" + selectedMovieID;
                            dbCmd.ExecuteNonQuery();

                            moviePoster.Image = Image.FromFile(@imagePath);
                            moviePoster.SizeMode = PictureBoxSizeMode.StretchImage;

                            this.loadMovies(sender, e);
                            this.lblMessage.Text = "Movie Poster Updated Successfully!!";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("You can not upload the same image.");
                        }
                    }
                }
            }
        }
    }
}
