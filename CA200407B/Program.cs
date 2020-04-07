using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CA200407B
{
    class Program
    {
        static List<Jatekos> jatekosok;
        static int fordSzam;
        static int fordSorSzam;
        static void Main()
        {
            F02();
            F03();
            F04();
            F05();
            F06();
            F07();
            Console.ReadKey();
        }

        private static void F07()
        {
            Console.Write("7. feladat: ");
            Console.Write($"Kérem a forduló sorszámát [1 - {fordSzam}]: ");
            var fss = int.Parse(Console.ReadLine());
            fordSorSzam = (fss > 0 && fss <= fordSzam) ? fss : 0;
        }

        private static void F06()
        {
            Console.Write("6. feladat: ");
            int mv = int.MinValue;
            foreach (var j in jatekosok)
                foreach (var t in j.Tippek)
                    if (mv < t) mv = t;
            Console.WriteLine($"Legnagyott tipp a fordulók során: {mv}");

            //LINQ
            //Console.WriteLine(jatekosok.Max(x => x.Tippek.Max());
        }

        private static void F05()
        {
            Console.Write("5. felafat: ");
            int i = 0;
            while (i < jatekosok.Count && jatekosok[i].Tippek[0] != 1) i++;
            if (i < jatekosok.Count) Console.WriteLine("Az első fordulóban VOLT egyes tipp");
            else Console.WriteLine("Az első fordulóban NEM volt egyes tipp");

            //LINQ
            //bool r = jatekosok.Any(x => x.Tippek[0] == 1);
            //Console.WriteLine(r);

            //FLINQ
            //Console.WriteLine(jatekosok.Any(x => x.Tippek[0] == 32) ? "VOLT" : "NEM VOLT");
        }

        private static void F04()
        {
            Console.Write("4. feladat: ");
            fordSzam = jatekosok[0].Tippek.Length;
            Console.WriteLine($"Fordulók száma: {fordSzam}");
        }

        private static void F03()
        {
            Console.Write("3. feladat: ");
            Console.WriteLine($"Játékosok száma: {jatekosok.Count}");
        }

        private static void F02()
        {
            jatekosok = new List<Jatekos>();
            var sr = new StreamReader(@"..\..\Res\egyszamjatek.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                jatekosok.Add(new Jatekos(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}
