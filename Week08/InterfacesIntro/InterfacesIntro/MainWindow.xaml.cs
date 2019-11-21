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

namespace InterfacesIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<ILifeFunctions> LF;

        public MainWindow()
        {
            InitializeComponent();
            LF = new ObservableCollection<ILifeFunctions>();

            // make siome aminals
            Frog frog = new Frog(4,"Bart",true, 400000000);
            Dog dog = new Dog("Labradoodle", 35, "Pax", 2);
            Duck duck = new Duck(4, "Moo",69);
            RobotBoi bot = new RobotBoi(100, 50, "ABS plastic", "fred", false);

            LF.Add(frog);
            LF.Add(dog);
            LF.Add(duck);
            LF.Add(bot);
            

            lvAnimals.ItemsSource = LF;
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Animal a in LF)
            {
                a.SayName();
            }
        }

		private void LvAnimals_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			Animal selectedAnimal = lvAnimals.SelectedItem as Animal;
			if (selectedAnimal != null)
			{
				selectedAnimal.Speak();
			}
		}
	}
}
