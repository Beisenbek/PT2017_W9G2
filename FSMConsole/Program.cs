using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMConsole
{

    class Program
    {
        static void Main(string[] args)
        {
            States s = new States();
            s.invoker = DisplayResultOnConsole;

            while (true)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.D2:
                    case ConsoleKey.D3:
                    case ConsoleKey.D4:
                    case ConsoleKey.D5:
                    case ConsoleKey.D6:
                    case ConsoleKey.D7:
                    case ConsoleKey.D8:
                    case ConsoleKey.D9:
                    case ConsoleKey.D0:
                        s.Process(pressedKey.KeyChar);
                        break;
                    case ConsoleKey.D:
                        s.Process('.');
                        break;
                    case ConsoleKey.P:
                        s.Process('+');
                        break;
                    case ConsoleKey.M:
                        s.Process('-');
                        break;
                    case ConsoleKey.E:
                        s.Process('=');
                        break;
                }
            }
        }

        static void DisplayResultOnConsole(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
        }
    }
}
