using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rossi_Esercizio2Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("numero corridori: ");
            int n = int.Parse(Console.ReadLine());
            List<string> partecipanti = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"come si chiama {i}:");
                string name = Console.ReadLine();
                partecipanti.Add(name);
            }
            for(int i = 1; i <= n; i++)
            {
                Thread thread = new Thread(() => corsa(partecipanti[i]));
                thread.Start();

            }

            Console.ReadLine();

        }
        private static void corsa(string name)
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine($"il corridore {name} ha percorso {i} ");
            }
            Console.WriteLine($"la gara {name}");

        }

    }
}
