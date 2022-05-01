using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace мин__макс_линком
{
    internal class Program
    {
        static int MinByLinq(IEnumerable<int> myList) {return myList.Min();}
        static int MaxByLinq(IEnumerable<int> myList) {return myList.Max();}

        static int MinIndexByLinq(IEnumerable<int> myList) => myList.IndexOf(MinByLinq(myList));
        static void Main(string[] args)
        {
        }
    }
}
