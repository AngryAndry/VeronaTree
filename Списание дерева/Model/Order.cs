using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Списание_дерева.Model
{
    class Order
    {
        public string model { get; set; }
        public string numberOrder { get; set; }
        public DateTime date { get; set; }
        public string treeSpecies { get; set; }
        public float length { get; set; }
        public float width { get; set; }
        public float height { get; set; }
        public int amount { get; set; }
        
    }
}
