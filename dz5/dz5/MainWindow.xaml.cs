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

namespace dz5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            games.Add(new Game("GTA", "Arcade", "+", "Ps"));
            games.Add(new Game("Mario", "Arcade", "-", "Nintendo"));
            games.Add(new Game("Dota", "MOBA", "+", "PC"));
            games.Add(new Game("WarCraft", "MOBA", "+", "PC"));
            games.Add(new Game("Linage2", "MORPG", "+", "PC"));
            games.Add(new Game("FIFA", "Simulator", "+", "All"));
            LoadGame(games);

        }
        public class Game
        {
            public string name { get; set; }
            public string janr { get; set; }
            public string rpg { get; set; }
            public string platforma { get; set; }

            public Game(string _name, string _janr, string _rpg, string _platform)
            {
                this.name = _name;
                this.janr = _janr;
                this.rpg = _rpg;
                this.platforma = _platform;
            }
        }
        public List<Game> games = new List<Game>();
        public void LoadGame(List<Game> games)
        {
            gameList.Items.Clear();
            for (int i = 0; i < games.Count; i++)
            {
                gameList.Items.Add(games[i]);
            }
        }
        private void ActiveFilter(object sender, RoutedEventArgs e)
        {
            List<Game> newGames = new List<Game>();
            newGames = games;
            if (rpgFilter.SelectedIndex == 0)
                newGames = games.FindAll(x => x.rpg == "+");
            else
                newGames = games.FindAll(x => x.rpg == "-");
            LoadGame(newGames);
            newGames = newGames.FindAll(x => x.name.Contains(nameFilter.Text));
        }
       
    }


               
}

