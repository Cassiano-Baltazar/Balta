using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EditorHtml {
  internal class Viewer {
    public static void Show(string text) {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.Clear();

      Console.WriteLine("Modo Visualização");
      Console.WriteLine("-----------");
      Replace(text);
      Console.WriteLine("-----------");
      Console.ReadKey();
      Menu.Show();
    }

    public static void Replace(string text) {
      var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
      var words = text.Split(' ');
      foreach (var word in words) {
        if (strong.IsMatch(word)) {
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.Write(
            word.Substring(
              word.IndexOf('>') + 1,
              (
                (word.LastIndexOf('<') - 1) -
                word.IndexOf('>')
              )
            )
          );
        } else {
          Console.ForegroundColor = ConsoleColor.Black;
          Console.Write(word);
        }

        Console.Write(" ");
      }
    }
  }
}
