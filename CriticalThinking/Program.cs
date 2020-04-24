using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class Program
    {
        static void Main(string[] args)
        {
            Application solitaire = new Game("Solitaire", "Game", 8, 1.3, 2000);
            Application sublime = new TextEdit("Sublime", "Text Edit", 8, 45);
            Application slack = new Messenger("Slack", "Messenger", 8, 35);
            Computer computer = new Computer();
            computer.motherboard.InstallApplication(solitaire);
            computer.motherboard.InstallApplication(slack);
            computer.motherboard.InstallApplication(sublime);
            Console.ReadLine();
        }
    }
}
