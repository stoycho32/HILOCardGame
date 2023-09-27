using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HILOCardGame.Models.Interfaces
{
    public interface ICard
    {
        public string CardType { get; }
        public string CardSuit { get; }
        public int CardValue { get; }
    }
}
