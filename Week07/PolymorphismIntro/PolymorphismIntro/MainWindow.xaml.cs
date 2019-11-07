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

namespace PolymorphismIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Animal> Animals;

        public MainWindow()
        {
            InitializeComponent();
            Animals = new ObservableCollection<Animal>();

            Frog frog = new Frog(69,"Bort",true);
            Dog dog = new Dog("???", 3, "[REDACTED]");
            Duck duck = new Duck(400, "Matt");

            Animals.Add(frog);
            Animals.Add(dog);
            Animals.Add(duck);

            lvAnimals.ItemsSource = Animals;

        }


        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
           foreach(Animal x in Animals)
            {
                x.SayName();
            } 
        }
    }
}
