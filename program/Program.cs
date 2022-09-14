using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prosjek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // inicijalizacija varijabli
            int brojOcjena = 0, ocjena = 0;
            double prosjek = 0.0, zbrojOcjena = 0;

            // zaglavlje aplikacije
            Console.WriteLine("##########################");
            Console.WriteLine("# Izračunavanje prosjeka #");
            Console.WriteLine("##########################");
            Console.WriteLine("Za kraj unesi nulu");
            
            // unos broja ocjena
            /*Console.WriteLine("Unesi broj ocjena");
            brojOcjena = Convert.ToInt32(Console.ReadLine());*/

            // unos ocjena
            Console.WriteLine("Unesi ocjene");
            do
            {
                upis:
                ocjena = Convert.ToInt32(Console.ReadLine());
                if (ocjena > 1)
                {
                    // povratak na unos ako je ocjena veća od 5
                    if (ocjena > 5)
                    {
                        Console.WriteLine("Krivi upis, pokušaj ponovo");
                        goto upis;

                    }

                    zbrojOcjena += ocjena;

                }
                // obavjest da pada razred ako ima 1
                else if (ocjena == 1)
                {
                    Console.WriteLine("Nisi prošao razred.");
                    break;

                }

                brojOcjena++ ;      //brojač ocjena
            } while (ocjena != 0);

            //ispis prosjeka ako nema 1
            if(ocjena != 1)
            {
                prosjek = zbrojOcjena / (brojOcjena-1);
                Console.WriteLine("Prosjek ocjena je " + prosjek + ".");

            }

            Console.ReadKey();

        }

    }

}