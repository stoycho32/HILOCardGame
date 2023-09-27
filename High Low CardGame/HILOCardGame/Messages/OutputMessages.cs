using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HILOCardGame.Messages
{
    public static class OutputMessages
    {
        public const string PickAnOption = "Please Pick An Option?";
        public const string CardGuessed = "You Guessed The Card!!!";
        public const string CardNotGuessed = "Wrong Choice.";
        public const string PointsEarned = "You Have Earned {0} Points!";
        public const string CardDeckCreated = "New Card Deck Was Shuffled And Created!";
        public const string ChooseNextCardValue = "Lower/Equal Or Higher/Equal: ";

        //App interface messages:
        public const string SelectOption = "Please Select An Option:";
        public const string PlayGameOption = "1. Play Game";
        public const string BetHistoryOption = "2: Check Bet History";
        public const string BetByIdOption = "3: Find Bet By Id";
        public const string ExitOption = "4: Exit";
        public const string WonLabel = "Won!";
        public const string LostLabel = "Lost";
        public const string GameOptions = "l: Lower Card\nh: Higher Card\ne: Exit";
    }
}
