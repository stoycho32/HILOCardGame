using HILOCardGame.Core.Contracts;
using HILOCardGame.Core.Interfaces;
using HILOCardGame.IO.Contracts;
using HILOCardGame.IO.Entities;
using HILOCardGame.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HILOCardGame.Core.Entities
{
    public class Engine : Object, IEngine
    {
        private IController controller;
        private IWriter consoleWriter;
        private IReader consoleReader;

        public Engine()
        {
            this.controller = new Controller();
            this.consoleWriter = new ConsoleWriter();
            this.consoleReader = new ConsoleReader();
        }

        public void Run()
        {
            while(true)
            {
                try
                {
                    this.consoleWriter.WriteLine(OutputMessages.SelectOption);
                    this.consoleWriter.WriteLine(OutputMessages.PlayGameOption);
                    this.consoleWriter.WriteLine(OutputMessages.BetHistoryOption);
                    this.consoleWriter.WriteLine(OutputMessages.BetByIdOption);
                    this.consoleWriter.WriteLine(OutputMessages.ExitOption);
                    string selection = this.consoleReader.ReadLine();

                    if (selection == "1")
                    {
                        Console.Clear();
                        this.controller.StartGame();
                        Console.Clear();
                    }
                    else if (selection == "2")
                    {
                        Console.Clear();
                        this.consoleWriter.WriteLine("All Bets");
                        this.controller.GetBetHistory();
                        this.consoleWriter.WriteLine($"1: Exit");
                        selection = this.consoleReader.ReadLine();
                        Console.Clear();
                    }
                    else if (selection == "3")
                    {
                        Console.Clear();
                        this.consoleWriter.Write("Please Enter Bet ID: ");
                        string betId = this.consoleReader.ReadLine();
                        Console.Clear();
                        this.controller.SelectBetById(betId);
                        this.consoleWriter.WriteLine($"1: Exit");
                        selection = this.consoleReader.ReadLine();
                        Console.Clear();
                    }
                    else if (selection == "4")
                    {
                        Environment.Exit(0);
                    }
                }
                catch (ArgumentException ae)
                {
                    this.consoleWriter.WriteLine(ae.Message);
                }
                catch (InvalidOperationException ioe)
                {
                    this.consoleWriter.WriteLine(ioe.Message);
                }
                catch (Exception e)
                {
                    Console.Clear();
                    this.consoleWriter.WriteLine(e.Message);
                }
            }
        }
    }
}
