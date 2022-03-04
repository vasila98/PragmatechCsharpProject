using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClass
{
    internal class Book
    {
        public string Name;
        public int PageCount;
        

        public Book(string nm, int pgcnt)
        {
            Name = nm;
            PageCount = pgcnt;
        }
    }
}
