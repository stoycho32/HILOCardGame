using HILOCardGame.IO.Contracts;
using HILOCardGame.IO.Entities;
using HILOCardGame.Messages;
using HILOCardGame.Models.Contracts;
using HILOCardGame.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HILOCardGame.Models.Entities
{
    public class Round : IRound
    {
        private Guid roundId;
        private ICard currentCard;
        private ICard nextCard;
        private string choice;
        private string roundStatus;

        public Round(ICard currentCard, ICard nextCard, string choice, string roundStatus)
        {
            this.roundId = Guid.NewGuid();
            this.CurrentCard = currentCard;
            this.NextCard = nextCard;
            this.choice = choice;
            this.RoundStatus = roundStatus;
        }

        public Guid RoundId
        {
            get => this.roundId;
            private set
            {
                this.roundId = value;
            }
        }

        public ICard CurrentCard
        {
            get => this.currentCard; 
            private set
            {
                this.currentCard = value;
            }
        }

        public ICard NextCard
        {
            get => this.nextCard;
            private set
            {
                this.nextCard = value;
            }
        }

        public string RoundStatus
        {
            get => this.roundStatus;
            private set
            {
                this.roundStatus = value;
            }
        }

        public string Choice
        {
            get => this.choice;
            private set
            {
                this.choice = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"ID: {this.RoundId} ");
            sb.AppendLine($"Current Card: {this.CurrentCard} ");
            sb.AppendLine($"Next Card: {this.NextCard} ");
            sb.AppendLine($"Choice: {this.Choice} ");
            sb.AppendLine($"Outcome: {this.RoundStatus} ");
            return sb.ToString().TrimEnd();
        }
    }
}
