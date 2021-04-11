using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Greet("german"));
            Console.ReadLine();
        }

        public static string Greet(string language)
        {
            string result;
            var languages = new Dictionary<string, string>()
          {
          {"english", "Welcome"},
          {"czech", "Vitejte"},
          {"danish", "Velkomst"},
          {"dutch", "Welkom"},
          {"estonian", "Tere tulemast"},
          {"finnish", "Tervetuloa"},
          {"flemish", "Welgekomen"},
          {"french", "Bienvenue"},
          {"german", "Willkommen"},
          {"irish", "Failte"},
          {"italian", "Benvenuto"},
          {"latvian", "Gaidits"},
          {"lithuanian", "Laukiamas"},
          {"polish", "Witamy"},
          {"spanish", "Bienvenido"},
          {"swedish", "Valkommen"},
          {"welsh", "Croeso"}
          };

            languages.TryGetValue(language, out result);
            return result == null ? languages["english"] : result;
        }
    }
}
