using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Списание_дерева.Model
{
    public class Order
    {
        public int Id { get; set; }
        public string? numberOrder { get; set; }
        public string? model { get; set; }
        public string? date { get; set; }
        
        public List<Semimanufactures> semimanufactures = new List<Semimanufactures>();
        /*public string treeSpecies { get; set; }
        public int length { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int amount { get; set; }*/
       // public Order(string _model,string _numberOrder,DateTime _date,string _treeSpecies,int _length,int _width,int _height,int _amouunt)
        public Order(string _model,string _numberOrder, DateTime _date)
        {
            model = _model;
            numberOrder = _numberOrder;
           // date = _date;
        
          /*  treeSpecies = _numberOrder;
            length = _length;
            width = _width;
            amount = _amouunt;*/
        }
        public Order()
        {
            
        }
    }
}
