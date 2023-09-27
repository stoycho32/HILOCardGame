using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HILOCardGame.Models.Interfaces
{
    public interface ICardDeck
    {
        public int CountOfCardsLeft { get; }
        public IReadOnlyCollection<ICard> CardDeck { get; }
        public ICard DrawCard();
    }
}
