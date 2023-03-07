using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOp
{
    public class Coda : ColdDrink
    {
        private String codaName;
        public Coda(String codaName, int cost) : base(cost)
        {
            name = "Холодный";
            this.codaName = codaName;
        }
         public new int temperature()
        {
            return 3;
        }
        public String getCodaName(){
            return codaName;
        }

    }
}