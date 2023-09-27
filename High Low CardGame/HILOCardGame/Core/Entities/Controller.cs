using HILOCardGame.Core.Contracts;
using HILOCardGame.IO.Contracts;
using HILOCardGame.IO.Entities;
using HILOCardGame.Messages;
using HILOCardGame.Models.Contracts;
using HILOCardGame.Models.Entities;
using HILOCardGame.Models.Interfaces;
using HILOCardGame.Repositories.Contracts;
using HILOCardGame.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HILOCardGame.Core.Entities
{
    public class Controller : IController
    {
        private ICardDeck cardDeck;
        private IWriter consoleWriter;
        private IReader consoleReader;
        private IRepository<IRound> roundRepository;

        public Controller()
        {
            this.cardDeck = new CardDeck();
            this.consoleWriter = new ConsoleWriter();
            this.consoleReader = new ConsoleReader();
            this.roundRepository = new RoundRepository();
        }

        public void GetBetHistory()
        {
            if (this.roundRepository.Models.Count > 0)
            {
                this.roundRepository.GetBetHistory();
            }
            else
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.NoBetsInGameHistory));
            }
        }

        public void SelectBetById(string id)
        {
            IRound round = this.roundRepository.FindById(id);

            if (round != null)
            {
                this.consoleWriter.WriteLine(round.ToString());
            }
            else
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InvalidBetId, id));
            }
        }

        public void StartGame()
        {
            ICard currentCard = null;
            ICard nextCard = null;

            while (true)
            {
                if (currentCard == null)
                {
                    currentCard = this.cardDeck.DrawCard();
                }

                this.consoleWriter.WriteLine(currentCard.ToString());
                this.consoleWriter.Write(OutputMessages.ChooseNextCardValue);

                string choice = this.consoleReader.ReadLine();

                if (choice == "e")
                {
                    break;
                }

                nextCard = this.cardDeck.DrawCard();
                this.consoleWriter.WriteLine(nextCard.ToString());

                Console.Clear();
                if (choice == "l" && currentCard.CardValue >= nextCard.CardValue ||
                    choice == "h" && currentCard.CardValue <= nextCard.CardValue)
                {
                    this.consoleWriter.WriteLine(OutputMessages.WonLabel);
                    IRound round = new Round(currentCard, nextCard, choice, "Won");
                    this.roundRepository.AddToRepository(round);
                }
                else
                {
                    this.consoleWriter.WriteLine(OutputMessages.LostLabel);
                    IRound round = new Round(currentCard, nextCard, choice, "Lost");
                    this.roundRepository.AddToRepository(round);
                }

                currentCard = nextCard;
            }
        }

    }
}
