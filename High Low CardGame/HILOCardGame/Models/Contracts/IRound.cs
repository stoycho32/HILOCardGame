using HILOCardGame.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HILOCardGame.Models.Contracts
{
    public interface IRound
    {
        public Guid RoundId { get; }
        public ICard CurrentCard { get; }
        public ICard NextCard { get; }
        public string Choice { get; }
        public string RoundStatus { get; }
    }
}
