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
      int c_stock = 0;
      int h_price = 9229;
      int m_price = 2626;
      int c_price = 7173;
      
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
          Console.WriteLine("Meth: " + m_stock);
          Console.WriteLine("Cocaine: " + c_stock);
          
          Console.WriteLine("---SELL---");
          Console.WriteLine("1. Heroin: $" + h_price);
          Console.WriteLine("2. Meth: $" + m_price);
          Console.WriteLine("3. Cocaine: $" + c_price);
          Console.WriteLine("4. BACK: ")
          SellChoice = Console.ReadLine();
          
          if(SellChoice == "1" && h_stock =< 1) {
            
          }
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
            
          Console.WriteLine("1 || HEROIN: $"+ h_price);
          Console.WriteLine("2 || METH: $" + m_price);
          Console.WriteLine("3 || COCAINE: $" + c_price);
          
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
