using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizsga_console
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Seged> sorsolas_list = new List<Seged>();
            string[] lines = File.ReadAllLines("sorsolas.txt");

            foreach (var item in lines)
            {
                string[] values = item.Split(';');
                Seged sorsolas_object = new Seged(values[0], values[1], values[2], values[3], values[4], values[5]);
                sorsolas_list.Add(sorsolas_object);
            }

            //2.feladat

            bool feltetel = true;
            while(feltetel)
            {
                Console.WriteLine("Adj meg egy számot 1-52: ");
                string beker = Console.ReadLine();
                int beker_szam;
                if(int.TryParse(beker, out beker_szam))
                {
                    beker_szam = int.Parse(beker);
                    if(beker_szam<53 && beker_szam >= 1)
                    {
                        foreach (var item in sorsolas_list)
                        {
                            if (beker_szam == item.het)
                                Console.WriteLine($"A {item.het}. hét nyerőszámai: {item.sz1}, {item.sz2}, {item.sz3}, {item.sz4},{item.sz5}");
                        }
                        feltetel = false;
                    }
                    else
                        Console.WriteLine("Nincs a kért tartományban");
                }
                else
                    Console.WriteLine("nem számot adtál meg.");
            }

            //3.feladat 

            List<Szam> szamok = new List<Szam>();
            int db = 0;
            for (int i = 1; i < 91; i++)
            {
                foreach (var item in sorsolas_list)
                {
                    if (i == item.sz1 || i == item.sz2 || i == item.sz3 || i == item.sz4 || i == item.sz5)
                        db++;
                }
                Szam szam_object = new Szam(i, db);
                szamok.Add(szam_object);
                db = 0;
            }

            int min = int.MaxValue;
            int legkisebb=0;
            foreach (var item in szamok)
            {
                if(min> item.db)
                {
                    min = item.db;
                    legkisebb = item.szam;
                }
            }

            Console.WriteLine($"Legkisebb szám: {legkisebb}: {min}");

            //4. feladat 

            int paros = 0;
            foreach (var item in szamok)
            {
                if (item.szam % 2 == 0)
                    paros += item.db;
            }
            Console.WriteLine($"páros számok: {paros}");

            // 5. feladat
            int szam5 = 0;
            foreach (var item in szamok)
            {
                if (item.szam == 46)
                    szam5 = item.db;
            }
            Console.WriteLine($"5ös szám: {szam5}");

            //7.feladat

            foreach (var item in szamok)
            {
                Console.WriteLine($"{item.szam}---{item.db}");
            }


            Console.ReadKey();
        }
    }
}
