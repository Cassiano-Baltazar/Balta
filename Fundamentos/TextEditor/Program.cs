namespace TextEditor {
  internal class Program {
    static void Main(string[] args) {
      Menu();
    }

    static void Menu() {
      Console.Clear();
      Console.WriteLine("O que você deseja fazer?");
      Console.WriteLine("1 - Abrir arquivo");
      Console.WriteLine("2 - Criar novo arquivo");
      Console.WriteLine("0 - Sair");
      short option = short.Parse(Console.ReadLine() ?? "");

      switch (option) {
        case 0:
          System.Environment.Exit(0);
          break;
        case 1:
          Open();
          break;
        case 2:
          Edit();
          break;
        default:
          Menu();
          break;
      }
    }

    static void Open() {
      Console.Clear();
      Console.WriteLine("Qual o caminho do arquivo");
      string path = Console.ReadLine() ?? "";
      using (var stream = new StreamReader(path)) {
        string text = stream.ReadToEnd();
        Console.WriteLine(text);
      }

      Console.ReadLine();
      Menu();
    }

    static void Edit() {
      Console.Clear();
      Console.WriteLine("Digite seu texto abaixo (Esc para sair)");
      Console.WriteLine("-----------------------");
      string text = "";

      do {
        if (text.Length > 0)
          text += Environment.NewLine;
        text += Console.ReadLine();        
      } while (Console.ReadKey().Key != ConsoleKey.Escape);

      Save(text);
    }

    static void Save(string text) {
      Console.Clear();
      Console.WriteLine("Qual caminho?");
      var path = Console.ReadLine() ?? "";

      using (var stream = new StreamWriter(path)) {
        stream.Write(text);
      };

      Console.WriteLine($"Arquivo {path} foi salvo com sucesso");
      Console.ReadLine();
      Menu();
    }
  }
}
