using HILOCardGame.Messages;
using HILOCardGame.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HILOCardGame.Models.Entities
{
    public class Card : Object, ICard
    {
        private string cardType;
        private string cardSuit;
        private int cardValue;

        public Card(string cardType, string cardSuit, int cardValue)
        {
            this.CardType = cardType;
            this.CardSuit = cardSuit;
            this.CardValue = cardValue;
        }

        public string CardType
        {
            get => this.cardType;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.CardTypeCannotBeZeroOrEmpty, nameof(this.CardType)));
                }
                this.cardType = value;
            }
        }

        public string CardSuit
        {
            get => this.cardSuit;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.CardTypeCannotBeZeroOrEmpty, nameof(this.CardSuit)));
                }
                this.cardSuit = value;
            }
        }

        public int CardValue
        {
            get => this.cardValue;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.CardValueCannotBeBelowOrEqualToZero, nameof(this.CardValue)));
                }
                this.cardValue = value;
            }
        }
        
        public override string ToString()
        {
            return $"{this.CardType}{this.CardSuit}: {this.CardValue}";
        }
    }
}
