using HILOCardGame.Core.Entities;
using HILOCardGame.Core.Interfaces;
using HILOCardGame.DesignPattern.Contracts;
using HILOCardGame.DesignPattern.Entities;
using HILOCardGame.Messages;
using HILOCardGame.Models.Contracts;
using HILOCardGame.Models.Entities;
using HILOCardGame.Models.Interfaces;
using System.Runtime.CompilerServices;

namespace HILOCardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}