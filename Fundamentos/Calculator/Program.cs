namespace Calculator {
  internal class Program {
    static void Main(string[] args) {
      Menu();
    }

    static void Menu() {
      Console.Clear();
      Console.WriteLine("Menu");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Divisão");
      Console.WriteLine("4 - Multiplicação");
      Console.WriteLine("5 - Sair");

      Console.WriteLine("---------------");
      Console.WriteLine("Informe a opção");
      short Opcao = short.Parse(Console.ReadLine());

      switch (Opcao) {
        case 1:
          Soma();
          break;
        case 2:
          Subtracao();
          break;
        case 3:
          Divisao();
          break;
        case 4:
          Multiplicacao();
          break;
        case 5:
          System.Environment.Exit(0);
          break;
        default:
          Menu();
          break;
      }
    }

    static void Soma() {
      Console.Clear();
      Console.WriteLine("Primeiro Valor:");
      float Valor1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Segundo Valor:");
      float Valor2 = float.Parse(Console.ReadLine());
      Console.WriteLine("");

      float Resultado = Valor1 + Valor2;
      Console.WriteLine($"O resultado da soma é {Resultado}");
      Console.ReadLine();
      Menu();
    }

    static void Subtracao() {
      Console.Clear();
      Console.WriteLine("Primeiro Valor:");
      float Valor1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Segundo Valor:");
      float Valor2 = float.Parse(Console.ReadLine());
      Console.WriteLine("");

      float Resultado = Valor1 - Valor2;
      Console.WriteLine($"O resultado da subtração é {Resultado}");
      Console.ReadLine();
      Menu();
    }

    static void Divisao() {
      Console.Clear();
      Console.WriteLine("Primeiro Valor:");
      float Valor1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Segundo Valor:");
      float Valor2 = float.Parse(Console.ReadLine());
      Console.WriteLine("");

      float Resultado = Valor1 / Valor2;
      Console.WriteLine($"O resultado da divisão é {Resultado}");
      Console.ReadLine();
      Menu();
    }

    static void Multiplicacao() {
      Console.Clear();
      Console.WriteLine("Primeiro Valor:");
      float Valor1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Segundo Valor:");
      float Valor2 = float.Parse(Console.ReadLine());
      Console.WriteLine("");

      float Resultado = Valor1 * Valor2;
      Console.WriteLine($"O resultado da Multiplicação é {Resultado}");
      Console.ReadLine();
      Menu();
    }
  }
}
