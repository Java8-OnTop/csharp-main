using System;

namespace main 
{
  class Program 
  {
    static void Main() 
    {
      Console.Writeline("Starting Game");
      
      //variables
      int money = 0;
      int msdelay = 300;
      int counter = 0;
      int h_stock = 0;
      int m_stock = 0;
      int h_stock = 0;
      
      Console.WriteLine("Game Started");
      Console.WriteLine("------CrimeSim------");
      Console.WriteLine("AVAILABLE CRIMES: ");
      Console.WriteLine("1. DRUGS");
      Console.WriteLine("2. WEAPONS");
      Console.WriteLine("3. ROBBERY");
      string option = Console.ReadLine();
      
      if(option == "1") {
        Console.WriteLine("(B) buy, (S) sell");
        string sellorbuy = Console.ReadLine();
        if(sellorbuy == "s") {
          
          Console.WriteLine("---STOCK---");
          Console.WriteLine("Heroin: " + h_stock);
          Console.WriteLine("Meth: " + m
        }
        if(sellorbuy == "B") {
          
          var random = new Random();
          var questions = new List<string>{
            "2382",
            "1827",
            "1811",
            "1928",
            "2928",
            "1222",
            "1917",
            "6225"};
          
          int index = random.Next(questions.Count);
          
          h_price = 9229
            
          Console.WriteLine("1 || HEROIN: $"+ h_price);
          Console.WriteLine("2 || METH: $" + 1222);
          Console.WriteLine("3 || COCAINE: $" + 8272);
          
          string buy = Console.ReadLine();
          
          if(buy == "1" && money < h_price) {
            money - h_price;
            int h_stock;
            h_stock++;
          }
        }
        
      }
    }
  }
}
