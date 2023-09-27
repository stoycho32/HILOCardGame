using HILOCardGame.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HILOCardGame.Core.Contracts
{
    public interface IController
    {
        public void StartGame();
        public void GetBetHistory();
        public void SelectBetById(string id);
    }
}
