using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOp
{
    public class ColdDrink : Produkt
    {
        public int temperature()
        {
            //throw new NotImplementedException();
            return 2;
        }
        
        public ColdDrink(string name, int cost) : base(name, cost)
        {

        }
        public ColdDrink(int cost) : base(cost)
        {

        }
    }
}