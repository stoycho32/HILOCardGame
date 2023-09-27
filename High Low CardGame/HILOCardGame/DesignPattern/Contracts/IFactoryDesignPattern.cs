using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HILOCardGame.DesignPattern.Contracts
{
    public interface IFactoryDesignPattern<T>
    {
        public T CreateObject(string[] args);
    }
}
