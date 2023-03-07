using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOp
{
    public class VendingtMaschine
    {
        private List<Produkt> produkts = new List<Produkt>();
        public void addProdukt(Produkt produkt){
            produkts.Add(produkt);
        }
        public void getProgukt(){
            foreach(Produkt item in produkts){
                Console.WriteLine("produkt Напиток - {0}. Цена = {1}", item.getName(),  item.getCost());
            }
        }
    }
}