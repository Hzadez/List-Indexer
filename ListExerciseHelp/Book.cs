using ListexerciseHelp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExerciseHelp
{
    public class Book
    {
        private static byte _count;
        public byte ID;
        public string Name;
        public string AuthorName;
        public int PageCount;
        public string Code;

        public Book(string name)
        {
            ID = ++_count;
            Name = name;
            Code = Helper.CreateBookCode(name, ID);
        }
        
    }
}
