using HILOCardGame.DesignPattern.Contracts;
using HILOCardGame.Messages;
using HILOCardGame.Models.Entities;
using HILOCardGame.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HILOCardGame.DesignPattern.Entities
{
    public class CardFactoryDesignPattern : IFactoryDesignPattern<ICard>
    {
        public ICard CreateObject(string[] args)
        {
            string cardType = args[0];
            string cardSuit = args[1];

            switch (cardType)
            {
                case "A": return new Card(cardType, cardSuit, 14);
                case "K": return new Card(cardType, cardSuit, 13);
                case "Q": return new Card(cardType, cardSuit, 12);
                case "J": return new Card(cardType, cardSuit, 11);
                default:
                    int cardValue = int.Parse(cardType);
                    return new Card(cardType, cardSuit, cardValue);
            }

            throw new ArgumentException(ExceptionMessages.InvalidCard, cardType);
        }
    }
}

