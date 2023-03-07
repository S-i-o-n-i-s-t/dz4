using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOp
{
    public class HotDrink : Produkt, Temperature
    {
        public int temperature()
        {
            //throw new NotImplementedException();
            return 80;
        }
        
        public HotDrink(string name, int cost) : base(name, cost)
        {

        }
        
        public HotDrink(int cost) : base(cost)
        {

        }
    }
}