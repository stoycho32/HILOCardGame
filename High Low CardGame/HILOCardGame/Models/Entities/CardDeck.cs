using HILOCardGame.DesignPattern.Contracts;
using HILOCardGame.DesignPattern.Entities;
using HILOCardGame.IO.Contracts;
using HILOCardGame.IO.Entities;
using HILOCardGame.Messages;
using HILOCardGame.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HILOCardGame.Models.Entities
{
    public class CardDeck : ICardDeck
    {
        private readonly string[] cardTypes =
        {
            "A",
            "K",
            "Q",
            "J",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
        };
        private readonly string[] cardSuits = 
        {
            "♠",
            "♥",
            "♣",
            "♦"
        };

        private IFactoryDesignPattern<ICard> cardFactoryDesignPattern;
        private Stack<ICard> cardDeck;

        public CardDeck()
        {
            this.cardFactoryDesignPattern = new CardFactoryDesignPattern();
            this.cardDeck = new Stack<ICard>();
            this.CreateDeck();
        }

        public int CountOfCardsLeft => this.cardDeck.Count;

        IReadOnlyCollection<ICard> ICardDeck.CardDeck => this.cardDeck.ToList().AsReadOnly();

        public ICard DrawCard()
        {
            if (this.cardDeck.Count > 0)
            {
                return this.cardDeck.Pop();
            }
            else
            {
                this.CreateDeck();
                return this.cardDeck.Pop();
            }
        }

        private void CreateDeck()
        {
            Random random = new Random();
            int randomCardTypeIndex = 0;
            int randomSuitTypeIndex = 0;

            for (int i = 0; i < 10; i++)
            {
                randomCardTypeIndex = random.Next(0, this.cardTypes.Length - 1);
                randomSuitTypeIndex = random.Next(0, this.cardSuits.Length - 1);

                string[] cardInfo = { this.cardTypes[randomCardTypeIndex], this.cardSuits[randomSuitTypeIndex] };

                cardDeck.Push(this.cardFactoryDesignPattern.CreateObject(cardInfo));
            }
        }
    }
}
