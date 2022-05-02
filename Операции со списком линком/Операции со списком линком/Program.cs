using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Операции_со_списком_линком
{
    internal class Program
    {
        public static int Summ (IEnumerable<int> myList) => myList.Sum();
        public static int Sqr(List<int> myList)
        {
            int res = 1;
            for(int i = 0; i < myList.Count; i++) { res *= myList[i]; }
            return res;
        }

        public static int MiddleNum(IEnumerable<int> myList)
        {
            return Summ(myList) / myList.Length;
        }
        static void Main(string[] args)
        {
        }
    }
}
