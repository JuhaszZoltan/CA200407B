using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200407B
{
    class Jatekos
    {
        public string Nev { get; set; }
        public int[] Tippek { get; set; }

        public Jatekos(string s)
        {
            var t = s.Split(' ');
            Nev = t[t.Length - 1];
            Tippek = new int[t.Length - 1];
            for (int i = 0; i < t.Length - 1; i++)
                Tippek[i] = int.Parse(t[i]);
        }
    }
}
