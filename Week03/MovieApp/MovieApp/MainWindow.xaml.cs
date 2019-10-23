using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MovieApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Movie> movieList = new ObservableCollection<Movie>();

        public MainWindow()
        {
            InitializeComponent();

            movieListView.ItemsSource = movieList;

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
             
        }

        private void sumbitButton_Click(object sender, RoutedEventArgs e)
        {
            Movie submitted = new Movie(givenTitle.Text, givenGenre.Text, double.Parse(givenReviewScore.Text));

            movieList.Add(submitted);

            /* THIS INFO IS CONFINED WITHIN THE CONSTRUCTOR
            submitted.title = givenTitle.Text;
            submitted.genre = givenGenre.Text;
            submitted.reviewScore = double.Parse(givenReviewScore.Text); */

            //submitted.displayInfo();

            givenTitle.Clear();
            givenGenre.Clear();
            givenReviewScore.Clear();
        }

        private void movieListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void movieListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Movie selected = movieListView.SelectedItem as Movie;
            selected.displayInfo();
        }
    }
}
