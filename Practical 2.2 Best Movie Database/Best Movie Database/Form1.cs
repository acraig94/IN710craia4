using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Best_Movie_Database
{
    public partial class Form1 : Form
    {
        private SortedDictionary<int, Movie> movieTable = new SortedDictionary<int, Movie>();

        public Form1()
        {
            InitializeComponent();

            //Dictionary<int, Movie> movieTable = new Dictionary<int, Movie>();
            // Seed data
            Movie movie1 = new Movie(1961, "West SideStory", "Jerome Robbins");
            Movie movie2 = new Movie(1972, "The Godfather", "Francis Ford Coppola");
            Movie movie3 = new Movie(1984, "Amadeus", "Milos Forman");
            Movie movie4 = new Movie(2015, "The Revenant", "Alejandro G. Iñárritu");

            movieTable.Add(movie1.Year, movie1);
            movieTable.Add(movie2.Year, movie2);
            movieTable.Add(movie3.Year, movie3);
            movieTable.Add(movie4.Year, movie4);



        }

        private void button_AddMovie_Click(object sender, EventArgs e)
        {
            try
            {
                int key = Convert.ToInt16(tb_AddYear.Text);
                if (!movieTable.ContainsKey(key))
                {
                    String movieTitle = tb_AddTitle.Text;
                    String movieDirector = tb_Director.Text;
                    Movie newMovie = new Movie(key, movieTitle, movieDirector);
                    movieTable.Add(key, newMovie);

                    tb_AddTitle.Clear();
                    tb_AddYear.Clear();
                    tb_Director.Clear();
                    listBox_Movie.Items.Clear();
                    listBox_Movie.Items.Add(newMovie.Title + " has been added");
                }
                else
                {
                    MessageBox.Show(key.ToString() + " already exists");
                }
            }
            catch (FormatException)
            {
                tb_AddTitle.Clear();
                tb_AddYear.Clear();
                tb_Director.Clear();
                MessageBox.Show("Please enter valid data");
            }
        }

        private void button_DeleteMovie_Click(object sender, EventArgs e)
        {            
            try
            {
                int key = Convert.ToInt16(tb_DeleteYear.Text);

                if (movieTable.ContainsKey(key))
                {
                    Movie selectedMovie = movieTable[key];
                    movieTable.Remove(key);
                    tb_DeleteYear.Clear();
                    listBox_Movie.Items.Clear();
                    listBox_Movie.Items.Add(selectedMovie.Title.ToString() + " has been deleted");
                }
                else
                {
                    MessageBox.Show(key.ToString() + " does not exist");
                }
            }
            catch (FormatException)
            {
                tb_DeleteYear.Clear();
                MessageBox.Show(tb_DeleteYear.Text + " is not a valid year");                
            }
                        
        }

        private void button_SearchMovie_Click(object sender, EventArgs e)
        {
            try
            {
                int key = Convert.ToInt16(tb_SearchYear.Text);

                if (movieTable.ContainsKey(key))
                {
                    Movie selectedMovie = movieTable[key];
                    tb_SearchYear.Clear();
                    listBox_Movie.Items.Clear();
                    listBox_Movie.Items.Add(selectedMovie.ToString());
                }
                else
                {
                    MessageBox.Show(key.ToString() + " not found");
                }
            }     
            catch (FormatException)
            {
                tb_SearchYear.Clear();
                MessageBox.Show(tb_SearchYear.Text + " is not a valid year");
            }     
        }

        private void button_PrintAll_Click(object sender, EventArgs e)
        {
            listBox_Movie.Items.Clear();

            foreach (KeyValuePair<int, Movie> currentMovie in movieTable)
            {
                //listBox_Movie.Items.Add("-----------------------------------------");                
                listBox_Movie.Items.Add(currentMovie.Value.ToString());
            }
        }
    }
}
