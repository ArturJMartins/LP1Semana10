using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public interface IView
    {
        void ShowMenu();
        void Ending();
        void UnknownInput();
        void AfterMenu();
        int AskMinScore();
        int AskForInput();
        void ListOfPlayers(IEnumerable<Player> playersToList);
        Player InsertPlayer();
        PlayerOrder AskForSortPlayerList();
    }
}