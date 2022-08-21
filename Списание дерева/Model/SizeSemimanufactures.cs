using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Списание_дерева.Model
{
    public class SizeSemimanufactures
    {
        public int Id { get; set; }
        public int length { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int amount { get; set; }

        public int semimanufacturesID { get; set; }
        public Semimanufactures? semimanufactures { get; set; }
        public SizeSemimanufactures(int _length, int _width, int _height, int _amount)
        {
            length = _length;
            width = _width;
            height = _height;
            amount = _amount;
        }   public SizeSemimanufactures()
        {
           
        }

    }
}
