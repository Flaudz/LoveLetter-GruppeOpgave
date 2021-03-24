using LoveLetter_GruppeOpgave.Model;
using LoveLetter_GruppeOpgave.ViewModel;
using LoveLetter_GruppeOpgave.ViewModel.Commands;
using System.Collections.ObjectModel;

namespace LoveLetter_GruppeOpgave.ViewModel
{
    public class HomeViewModel
    {
        public AddToLobbiesCommand AddToLobbiesCommand { get; set; }
        // Constructor tror jeg
        public ObservableCollection<Lobby> Lobbies
        {
            get;
            set;
        }

        public HomeViewModel()
        {
            AddToLobbiesCommand = new AddToLobbiesCommand(this);

            // Laver en Liste som indeholder alle Lobbies som skal vises på skærmen
            ObservableCollection<Lobby> lobbies = new ObservableCollection<Lobby>();
            Player Hermione = new Player(1, "Hermione Tanker");
            Player Harry = new Player(2, "Harry Lorter");
            Player Voldemort = new Player(3, "Pis");
            Lobby HermionesLobby = new Lobby(1, Hermione, 3, new ObservableCollection<Player> { Hermione, Harry, Voldemort });
            Lobby HarrysLobby = new Lobby(2, Harry, 3, new ObservableCollection<Player> { Harry, Hermione, Voldemort });

            lobbies.Add(HermionesLobby);
            lobbies.Add(HarrysLobby);

            Lobbies = lobbies;
        }

        // Den her function bliver kaldt af klik binding
        public void AddToLobbies()
        {
            Player NewPlayer = new Player(4, "RandomSquart");
            Lobby NewLobby = new Lobby(3, NewPlayer, 1, new ObservableCollection<Player> { NewPlayer });
            Lobbies[0].Id = 93;
            Lobbies.Add(NewLobby);
        }
    }
}
