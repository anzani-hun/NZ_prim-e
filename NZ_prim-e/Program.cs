using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ_prim_e
{
    internal class Program
    {
        static void Main()
        {
            // Konzolon kérjen be egy egész számot és írja ki, hogy prím-e a kapott érték.
            // pl: 2, 3, 5, 7, 11, 13, 17, 19, 23

            int adatBevitel;

            Console.Write("Kérek egy pozitív egész számot: ");
            adatBevitel = Convert.ToInt32(Console.ReadLine());

            // az érték true defaultban
            bool isPrimszam = true;

            if ( adatBevitel < 2 )
            {
                isPrimszam = false;
            }
            else
            {

                //ha a ciklust bejárva nem találunk osztót, akkor a szám prím
                for (int i = 2; i < adatBevitel; i++ )
                {
                    if (adatBevitel % i == 0)
                    {
                        isPrimszam = false;
                        break;
                    }
                  
                }
            }


            // prím vagy nem prim kiiratása
            if ( isPrimszam )
            {
                Console.WriteLine($"{adatBevitel} --> prímszám, mert csak kettő osztója van!");
            }
            else
            {
                Console.WriteLine($"{adatBevitel} --> NEM prímszám");
            }

            Console.ReadKey();

        }
    }
}
