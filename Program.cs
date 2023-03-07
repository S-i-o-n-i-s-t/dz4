// See https://aka.ms/new-console-template for more information
namespace OOp{
class Example
{
    public static void Main()
    {
        Console.WriteLine("Hello, World!"); 
        Produkt produkt1 = new Produkt("Cola",100);
        Console.WriteLine("produkt Напиток - {0}. Цена = {1}", produkt1.getName(),  produkt1.getCost());
        Produkt produkt2 = new Produkt("Fanta",90);
        Console.WriteLine("produkt Напиток - {0}. Цена = {1}", produkt2.getName(),  produkt2.getCost());

        HotDrink hotDrink = new HotDrink("latte" , 100);
        Console.WriteLine("produkt Напиток - {0}. Цена = {1}, Температура подачи = {2}",hotDrink.getName(), hotDrink.getCost(), hotDrink.temperature());

        Coda coda = new Coda("Cola", 120);
        Console.WriteLine("Напиток - {0}. Тип {1}. Цена = {2}, Температура подачи = {3}",coda.getCodaName() ,coda.getName(), coda.getCost(), coda.temperature());
        
        Tea tea = new Tea(220);
        Console.WriteLine("Напиток - {0}. Тип {1}. Цена = {2}, Температура подачи = {3}",tea.getTeaName() ,tea.getName(), tea.getCost(), tea.temperature());
        
        VendingtMaschine maschine = new VendingtMaschine();
        maschine.addProdukt(produkt1);
        maschine.addProdukt(produkt2);
        maschine.getProgukt();
    }
}
}

