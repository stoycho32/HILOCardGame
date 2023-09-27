using HILOCardGame.IO.Contracts;
using HILOCardGame.IO.Entities;
using HILOCardGame.Models.Contracts;
using HILOCardGame.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HILOCardGame.Repositories.Entities
{
    public class RoundRepository : IRepository<IRound>
    {
        private IWriter consoleWriter;
        private List<IRound> rounds;

        public RoundRepository()
        {
            this.consoleWriter = new ConsoleWriter();
            this.rounds = new List<IRound>();
        }

        public IReadOnlyCollection<IRound> Models => this.rounds.AsReadOnly();

        public void AddToRepository(IRound model)
        {
            this.rounds.Add(model);
        }

        public void GetBetHistory()
        {
            this.rounds.ForEach(r => this.consoleWriter.WriteLine(r.ToString()));
        }

        public IRound FindById(string id)
        {
            return this.rounds.FirstOrDefault(r => r.RoundId.ToString() == id);
        }
    }
}
