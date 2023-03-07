using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOp
{
    public class Tea : HotDrink 
    {
        private String teaName = "чай";
        public Tea(int cost) : base(cost)
        {
            name = "Горячий";
        }

         public new int temperature()
        {
            return 75;
        }
        public String getTeaName(){
            return teaName;
        }
    }
}