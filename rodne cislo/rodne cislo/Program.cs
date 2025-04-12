using System;

namespace rodne_cislo
{
    class Program
    {
        static void Main()
        {
            Console.Write("Zadejte rodné číslo: ");
            string rc = Console.ReadLine();

            if (rc.Length != 6)
            {
                Console.WriteLine("Špatně zadáno");
                return;
            }

            int rok = int.Parse(rc.Substring(0, 2));
            int mesic = int.Parse(rc.Substring(2, 2));
            int den = int.Parse(rc.Substring(4, 2));

            string pohlavi = "";
            if (mesic > 50)
            {
                pohlavi = "Žena";
                mesic -= 50;
            }
            else
            {
                pohlavi = "Muž";
            }

            if (mesic < 1 || mesic > 12)
            {
                Console.WriteLine("Špatný měsíc");
                return;
            }

            if (den < 1 || den > 31)
            {
                Console.WriteLine("Špatný den");
                return;
            }

            if (rok > 25)
            {
                rok += 1900;
            }
            else
            {
                rok += 2000;
            }

            string mesicNazev = "";
            switch (mesic)
            {
                case 1: mesicNazev = "leden"; break;
                case 2: mesicNazev = "unor"; break;
                case 3: mesicNazev = "brezen"; break;
                case 4: mesicNazev = "duben"; break;
                case 5: mesicNazev = "kveten"; break;
                case 6: mesicNazev = "cerven"; break;
                case 7: mesicNazev = "cervenec"; break;
                case 8: mesicNazev = "srpen"; break;
                case 9: mesicNazev = "zari"; break;
                case 10: mesicNazev = "rijen"; break;
                case 11: mesicNazev = "listopad"; break;
                case 12: mesicNazev = "prosinec"; break;
            }

            string text = "";
            if (pohlavi == "Žena")
            {
                text = "narozená";
            }
            else
            {
                text = "narozený";
            }

            Console.WriteLine($"{pohlavi}, {text} {den}.{mesicNazev} {rok}");
        }
    }
}
