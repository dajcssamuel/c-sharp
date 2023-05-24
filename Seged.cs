using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizsga_console
{
    class Seged
    {
        public int het;
        public int sz1;
        public int sz2;
        public int sz3;
        public int sz4;
        public int sz5;

        public Seged(string het, string sz1, string sz2, string sz3, string sz4, string sz5)
        {
            this.het = int.Parse(het);
            this.sz1 = int.Parse(sz1);
            this.sz2 = int.Parse(sz2);
            this.sz3 = int.Parse(sz3);
            this.sz4 = int.Parse(sz4);
            this.sz5 = int.Parse(sz5);
        }
    }
}
