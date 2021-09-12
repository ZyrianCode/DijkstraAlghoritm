using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra.Zyrian.MatrixManipulations.CustomList
{
    public class Container
    {
        public List<string> from = new List<string>();
        public List<string> where = new List<string>();
        public List<string> vertices = new List<string>();
        public List<int> cost = new List<int>();
        
        public Container GetEmptyContainer() => new();
    }
}
