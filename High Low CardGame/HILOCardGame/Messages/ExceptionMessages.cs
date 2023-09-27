using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HILOCardGame.Messages
{
    public static class ExceptionMessages
    {
        public const string CardTypeCannotBeZeroOrEmpty = "{0} cannot be null or empty";
        public const string CardValueCannotBeBelowOrEqualToZero = "{0} cannot be less or equal to zero.";
        public const string InvalidCard = "{0} is not a valid card type!";
        public const string InvalidBetId = "Bet With ID: {0} Was Not Found.";
        public const string NoBetsInGameHistory = "There Are No Bets.";
    }
}
