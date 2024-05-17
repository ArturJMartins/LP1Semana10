using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace PlayerManager4
{
    /// <summary>
    /// The player listing program.
    /// </summary>
    public class Controller
    {
        /// The list of all players
        private readonly List<Player> playerList;

        // Comparer for comparing player by name (alphabetical order)
        private readonly IComparer<Player> compareByName;

        // Comparer for comparing player by name (reverse alphabetical order)
        private readonly IComparer<Player> compareByNameReverse;

        private IView view;

        /// <summary>
        /// Creates a new instance of the player listing program.
        /// </summary>
        public Controller()
        {
            // Initialize player comparers
            compareByName = new CompareByName(true);
            compareByNameReverse = new CompareByName(false);

            // Initialize the player list with two players using collection
            // initialization syntax
            playerList = new List<Player>() {
                new Player("Best player ever", 100),
                new Player("An even better player", 500)
            };
        }

        /// <summary>
        /// Start the player listing program instance
        /// </summary>
        public void Start(IView view)
        {
            this.view = view;
            // We keep the user's option here
            int option;

            // Main program loop
            do
            {
                // Show menu and get user option
                view.ShowMenu();
                option = view.AskForInput();

                // Determine the option specified by the user and act on it
                switch (option)
                {
                    case 1:
                        // Insert player
                        InsertPlayer();
                        break;
                    case 2:
                        view.ListOfPlayers(playerList);
                        break;
                    case 3:
                        ListPlayersWithScoreGreaterThan();
                        break;
                    case 4:
                        SortPlayerList();
                        break;
                    case 0:
                        view.Ending();
                        break;
                    default:
                        view.UnknownInput();
                        break;
                }

                view.AfterMenu();
                

                // Loop keeps going until players choses to quit (option 4)
            } while (option != 0);
        }
        
        /// <summary>
        /// Inserts a new player in the player list.
        /// </summary>
        private void InsertPlayer()
        {
            // Variables
            Player newPlayer = view.InsertPlayer();
            // Create new player and add it to list
            playerList.Add(newPlayer);
        }
        
        /// <summary>
        /// Show all players with a score higher than a user-specified value.
        /// </summary>
        private void ListPlayersWithScoreGreaterThan()
        {
            // Minimum score user should have in order to be shown
            int minScore;
            // Enumerable of players with score higher than the minimum score
            IEnumerable<Player> playersWithScoreGreaterThan;

            // Ask the user what is the minimum score
            
            minScore = view.AskMinScore();

            // Get players with score higher than the user-specified value
            playersWithScoreGreaterThan =
                GetPlayersWithScoreGreaterThan(minScore);

            // List all players with score higher than the user-specified value
            view.ListOfPlayers(playersWithScoreGreaterThan);
        }

        /// <summary>
        /// Get players with a score higher than a given value.
        /// </summary>
        /// <param name="minScore">Minimum score players should have.</param>
        /// <returns>
        /// An enumerable of players with a score higher than the given value.
        /// </returns>
        private IEnumerable<Player> GetPlayersWithScoreGreaterThan(int minScore)
        {
            // Cycle all players in the original player list
            foreach (Player p in playerList)
            {
                // If the current player has a score higher than the
                // given value....
                if (p.Score > minScore)
                {
                    // ...return him as a member of the player enumerable
                    yield return p;
                }
            }
        }

        /// <summary>
        ///  Sort player list by the order specified by the user.
        /// </summary>
        private void SortPlayerList()
        {
            PlayerOrder playerOrder;

            playerOrder = view.AskForSortPlayerList();

            switch (playerOrder)
            {
                case PlayerOrder.ByScore:
                    playerList.Sort();
                    break;
                case PlayerOrder.ByName:
                    playerList.Sort(compareByName);
                    break;
                case PlayerOrder.ByNameReverse:
                    playerList.Sort(compareByNameReverse);
                    break;
                default:
                    view.UnknownInput();
                    break;
            }
        }
    }
}
