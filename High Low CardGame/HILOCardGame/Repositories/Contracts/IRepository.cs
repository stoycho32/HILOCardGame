using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HILOCardGame.Repositories.Contracts
{
    public interface IRepository<T>
    {
        public IReadOnlyCollection<T> Models { get; }
        public T FindById(string id);
        public void AddToRepository(T model);
        public void GetBetHistory();

    }
}
