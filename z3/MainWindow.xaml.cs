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

namespace z3
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Movies> movie = new ObservableCollection<Movies>();
        Add add = new Add();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this.GetMovies();
        }
        public ObservableCollection<Movies> GetMovies()
        {
            movie.Add(new Movies() { ID = 1, Title = "Ted", Director = "Seth MacFarlane", MovieStudio = "Universal Studios Entertainment", SavedOn = "USB", MovieLength = "106", ReleaseDate = "29.06.2012" });
            movie.Add(new Movies() { ID = 2, Title = "Annabelle Narodziny zła", Director = "David F. Sandberg", MovieStudio = "New Line Cinema", SavedOn = "DVD", MovieLength = "109", ReleaseDate = "11.08.2017" });
            movie.Add(new Movies() { ID = 3, Title = "Venom", Director = "Ruben Fleischer", MovieStudio = "Columbia Pictures", SavedOn = "USB", MovieLength = "112", ReleaseDate = "01.10.2018" });
            movie.Add(new Movies() { ID = 4, Title = "Shrek", Director = "Andrew Adamson", MovieStudio = "DreamWorks Animation", SavedOn = "DVD", MovieLength = "95", ReleaseDate = "22.04.2001" });

            return movie;
        }
        private void ShowAdd(object sender, RoutedEventArgs e)
        {
            add.AddNew();
        }
    }
}
