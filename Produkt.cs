using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOp
{
    public class Produkt
    {
        protected String name;
        protected int cost;

        public Produkt(String name, int cost) {
            this.name = name;
            this.cost = cost;
        }
        public Produkt(int cost) => this.cost = cost;



        public String getName(){
            return name;
        }
        public int getCost(){
            return cost;
        }
    }
}