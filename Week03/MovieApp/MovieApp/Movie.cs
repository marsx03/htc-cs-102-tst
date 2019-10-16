using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieApp
{
    class Movie
    {
        public string title;
        public string genre;
        public double reviewScore;
        public List<string> actors;

        public Movie(string title, string genre, double reviewScore)
        {
            this.title = title;
            this.genre = genre;
            this.reviewScore = reviewScore;
        }

        public void displayInfo()
        {
            MessageBox.Show($"Title: {title} \nGenre: {genre} \nReview Score: {reviewScore}");
        }
    }
}
