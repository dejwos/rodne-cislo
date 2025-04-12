using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rodne_cislo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte rodné číslo: ");
            string rodne_cislo = Console.ReadLine();
            
            if(rodne_cislo.Length == 6)
            {

            
            string pohlavi = "";
            string rok_narozeni = rodne_cislo.Substring(0, 2);
            string mesic = rodne_cislo.Substring(2, 2);
            string datum = rodne_cislo.Substring(4, 2);
            string mesic_cely = "";


            int mesic_int = int.Parse(mesic);
            int rok_narozeni_int = int.Parse(rok_narozeni);

            if(mesic_int <= 12 && mesic_int > 0)
            {
                pohlavi = "Muž";
            }
            else if(mesic_int > 50)
            {
                pohlavi = "Žena";
            }
            if(mesic_int > 12 && mesic_int < 50 || mesic_int < 1 || mesic_int > 62)
            {
                Console.WriteLine("Špatný měsíc");
                Console.Read();
                return;
            }

            if (int.Parse(rok_narozeni) > 25)
            {
                rok_narozeni_int += 1900;
            }
            else
            {
                rok_narozeni_int += 2000;
            }

            if(int.Parse(datum) > 31 || int.Parse(datum) < 1)
            {
                Console.WriteLine("Špatný den");
                Console.Read();
                return;
            }

            if(pohlavi == "Žena")
            {
                mesic_int -= 50;
                switch (mesic_int)
                {
                    case 01:
                        mesic_cely = "leden";
                        break;
                    case 02:
                        mesic_cely = "unor";
                        break;
                    case 03:
                        mesic_cely = "brezen";
                        break;
                    case 04:
                        mesic_cely = "duben";
                        break;
                    case 05:
                        mesic_cely = "kveten";
                        break;
                    case 06:
                        mesic_cely = "cerven";
                        break;
                    case 07:
                        mesic_cely = "cervenec";
                        break;
                    case 08:
                        mesic_cely = "srpen";
                        break;
                    case 09:
                        mesic_cely = "zari";
                        break;
                    case 10:
                        mesic_cely = "rijen";
                        break;
                    case 11:
                        mesic_cely = "listopad";
                        break;
                    case 12:
                        mesic_cely = "prosinec";
                        break;
                }
                Console.WriteLine($"{pohlavi}, narozená {datum}.{mesic_cely} {rok_narozeni_int}");
            }
            else
            {
                switch (mesic_int)
                {
                    case 01:
                        mesic_cely = "leden";
                        break;
                    case 02:
                        mesic_cely = "unor";
                        break;
                    case 03:
                        mesic_cely = "brezen";
                        break;
                    case 04:
                        mesic_cely = "duben";
                        break;
                    case 05:
                        mesic_cely = "kveten";
                        break;
                    case 06:
                        mesic_cely = "cerven";
                        break;
                    case 07:
                        mesic_cely = "cervenec";
                        break;
                    case 08:
                        mesic_cely = "srpen";
                        break;
                    case 09:
                        mesic_cely = "zari";
                        break;
                    case 10:
                        mesic_cely = "rijen";
                        break;
                    case 11:
                        mesic_cely = "listopad";
                        break;
                    case 12:
                        mesic_cely = "prosinec";
                        break;
                }
                Console.WriteLine($"{pohlavi}, narozený {datum}.{mesic_cely} {rok_narozeni_int}");
            }
            Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Špatně zadáno");
                Console.ReadLine();

            }
        }
    }
}
