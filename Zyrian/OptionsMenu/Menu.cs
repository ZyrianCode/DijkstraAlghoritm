using Dijkstra.Zyrian.Dijkstra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra.Zyrian.OptionsMenu
{
    public class Menu
    {
        public string ShowMenu()
        {
            Console.WriteLine("1 - Shortest path");
            Console.WriteLine("2 - Longest path");

            return Console.ReadLine();
        }

        public void StartMenu(DijkstraAlghoritm dijkstraAlghoritm)
        {
            switch (ShowMenu())
            {
                case "1":
                    {
                        Console.WriteLine("Введите откуда: ");
                        var from = Console.ReadLine();

                        Console.WriteLine("Введите куда: ");
                        var where = Console.ReadLine();

                        var path = dijkstraAlghoritm.FindShortestPathByName(from, where);

                        Console.WriteLine(path);
                        Console.ReadLine();
                        break;
                    }
                case "2":
                default:
                    Console.WriteLine("Упс, такого пункта не существует, у меня возникли лапки...");
                    break;
            }
        }

    }
}
