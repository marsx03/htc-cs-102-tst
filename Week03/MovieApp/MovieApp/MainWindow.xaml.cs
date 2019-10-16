using System;
using System.Collections.Generic;
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
        public MainWindow()
        {
            InitializeComponent();

            

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Movie submitted = new Movie(givenTitle.Text, givenGenre.Text, double.Parse(givenReviewScore.Text));

            /* THIS INFO IS CONFINED WITHIN THE CONSTRUCTOR
            submitted.title = givenTitle.Text;
            submitted.genre = givenGenre.Text;
            submitted.reviewScore = double.Parse(givenReviewScore.Text); */ 

            submitted.displayInfo();
        }
    }
}
