using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Списание_дерева.Model
{
    public class Semimanufactures
    {
        public int Id { get; set; }
        public string treeSpecies { get; set; }
     
        public int OrderId { get; set; }
        public Order? order { get; set; }

     
        public List<SizeSemimanufactures> sizeSemimanufactures = new  List<SizeSemimanufactures>();
        public Semimanufactures(string _treeSpecies)
        {
            treeSpecies = _treeSpecies;
        }  
        public Semimanufactures()
        {
          
        }
        
    
    }
}
