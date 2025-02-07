using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHtml {
  public static class Menu {
    public static void Show() {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.Blue;
      Console.ForegroundColor = ConsoleColor.Black;

      DrawScren();
      WriteOptions();

      var option = short.Parse(Console.ReadLine() ?? "0");
      HandleMenuOption(option);
    }

    public static void DrawTitle() {
      Console.Write("+");
      for (int i = 0; i <= 30; i++) {
        Console.Write("-");
      }
      Console.Write("+");
      Console.Write(Environment.NewLine);
    }

    public static void DrawScren() {
      DrawTitle();

      for (int i = 0; i <= 10; i++) {
        Console.Write('|');
        for (int j = 0; j <= 30; j++) {
          Console.Write(' ');
        }
        Console.Write('|');
        Console.Write(Environment.NewLine);
      }

      DrawTitle();
    }

    public static void WriteOptions() {
      Console.SetCursorPosition(3, 2);
      Console.Write("Editor HTML");
      Console.SetCursorPosition(3, 3);
      Console.Write("===========================");
      Console.SetCursorPosition(3, 4);
      Console.Write("Selecione uma opção");
      Console.SetCursorPosition(3, 6);
      Console.Write("1 - Novo arquivo");
      Console.SetCursorPosition(3, 7);
      Console.Write("2 - Abrir arquivo");
      Console.SetCursorPosition(3, 9);
      Console.Write("0 - Sair");
      Console.SetCursorPosition(3, 10);
      Console.Write("Opção: ");
    }

    public static void HandleMenuOption(short option) {
      switch (option) {
        case 1: {
          Editor.Show();
          break;
        }
        case 2: { 
          Console.WriteLine("View");
          break;
        }
        case 0: { 
          Console.Clear();
          Environment.Exit(0);
          break;
        }
        default: {
          Show();
          break;
        }
      }
    }
  }
}
