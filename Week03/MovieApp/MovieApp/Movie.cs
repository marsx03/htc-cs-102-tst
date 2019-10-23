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
        public string title { get; set; }
        public string genre { get; set; }
        public double reviewScore { get; set; }
        public int length { get; set; }
        public string director { get; set; }
        public string leadActor { get; set; }

        //public List<string> actors;

        public Movie(string title, string genre, double reviewScore, int length, string director, string leadActor)
        {
            this.title = title;
            this.genre = genre;
            this.reviewScore = reviewScore;
            this.length = length;
            this.director = director;
            this.leadActor = leadActor;
        }

        public void displayInfo()
        {
            MessageBox.Show($"Title: {title} \nGenre: {genre} \nReview Score: {reviewScore} \nLength: {length} \nDirector: {director} \nLead Actor: {leadActor}");
        }
    }
}
