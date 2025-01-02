using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace StopWatch {
  internal class Program {
    static void Main(string[] args) {
      Menu();
    }

    static void Menu() {
      Console.Clear();
      Console.WriteLine("S = Segundo => 10s = 10 segundos");
      Console.WriteLine("M = Minuto => 1m = 1 minuto");
      Console.WriteLine("0 = Sair");
      Console.WriteLine("Quanto Tempo deseja conta?");
      string data = (Console.ReadLine() ?? "0").ToLower();

      char type = data.Substring(data.Length - 1, 1)[0];
      if (type == '0')
        System.Environment.Exit(0);

      int tempo = int.Parse(data.Substring(0, data.Length - 1));
      int multiplier = 1;
      if (type == 'm')
        multiplier = 60;

      PreStart(tempo * multiplier);
    }

    static void PreStart(int time) {
      Console.Clear();
      Console.WriteLine("Ready...");
      Thread.Sleep(1000);
      Console.WriteLine("Set...");
      Thread.Sleep(1000);
      Console.WriteLine("Go...");
      Thread.Sleep(2500);
      Start(time);
    }

    static void Start(int time) {
      int currentTime = 0;

      while (currentTime != time) {
        Console.Clear();
        currentTime++;
        Console.WriteLine($"Segundo {currentTime}");
        Thread.Sleep(1000);
      }

      Console.Clear();
      Console.WriteLine("Stopwatch finalizado");
      Thread.Sleep(2500);
      Menu();
    }
  }
}
