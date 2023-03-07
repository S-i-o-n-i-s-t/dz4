using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOp
{
    public class Koffe : HotDrink
    {
        private String koffeName = "Кофе";
        public Koffe(int cost) : base(cost)
        {
            name = "Горячий";
        }

         public new int temperature()
        {
            return 80;
        }
        public String getKoffeName(){
            return koffeName;
        }
    }
}