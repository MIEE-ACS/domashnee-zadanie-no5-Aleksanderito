using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace дз5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            games.Add(new Game("FIFA", "Simulator", "+", "PS"));
            games.Add(new Game("Mario", "Advanture", "-", "Nintendo"));
            LoadGame(games);
         
        }
        public List<Game> games = new List<Game>();
        public void LoadGame(List<Game> _games)
        {
            gameList.Items.Clear();
            for (int i = 0; i < _games.Count; i++)
            {
                gameList.Items.Add(_games[i]);
            }
        }
        private void ActiveFilter(object sender, RoutedEventArgs e)
        {
            List<Game> newGame = new List<Game>();
            newGame = games;
            if (janrFilter.SelectedIndex == 0 && platformaFilter_Copy.SelectedIndex == 0)
                newGame = games.FindAll(x => x.Janr == "Simulator" );
            else
                newGame = games.FindAll(x => x.Janr == "Advanture");
            LoadGame(newGame);

        }
    }
    public class Game 
    {
    public string Name { get; set; }
    public string Janr { get; set; }
    public string RPG { get; set; }
    public string Platform { get; set; }
    
    public Game(string _Name, string _Janr, string _RPG, string _Platform)
        {
            this.Name = _Name; this.Janr = _Janr; this.RPG = _RPG; this.Platform = _Platform;
        }
    }
    
 
}

