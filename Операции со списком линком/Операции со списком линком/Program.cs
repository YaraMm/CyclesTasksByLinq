using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Операции_со_списком_линком
{
    internal class Program
    {
        public static int Summ(IEnumerable<int> myList) => myList.Sum(); //сумма элементов списка
        public static int Sqr(List<int> myList) // произведение элементов списка
        {
            //int res = 1;
            //foreach(int x in myList) { res *= x; }
            //return res;
            int res = myList.Aggregate((a, b) => a * b); //Aggregate круто!
            return res;        
        }

        public static int MiddleNum(IEnumerable<int> myList) { return myList.Sum() / myList.Count(); }
            //среднее арифметическое списка
        public static int NearestToMiddle (IEnumerable<int> myList) //ближайший к среднему арифметическому элемент
        {
            List<int> myL = new List<int>(myList);
            int counter = int.MaxValue;
            int middle = MiddleNum(myList);
            var dif = new List<int>();
            int res = 0;
            foreach(int x in myL) dif.Add(Math.Abs(middle - x));
            foreach(int x in myL) if(x - middle ==  dif.Min()) res = x;
            return res;
        }
        public static int IndexNearestToMiddle (IEnumerable<int> myList)
        {
            List<int> myL = new List<int>(myList);
            int nearestToMiddle = NearestToMiddle(myL);
            int c = 0;
            for(int i = 0; i < myL.Count; i++) if(myL[i] == nearestToMiddle) c = i;
            return c;
        }
        //Количество элементов списка, подходящих под определенные условия
        //(например, четные положительные элементы).
        //+ их сумма/произведение и т.д


        public static int EvenPositive (IEnumerable<int> myList)
        {
            IEnumerable<int> query = myList.Where(x => x % 2 == 0 && x > 0);
            return query.Count();   
        }
        static int SumEvenPositive (IEnumerable<int> myList) 
        {
            IEnumerable<int> query = myList.Where(x => x % 2 == 0 && x > 0);
            return query.Sum();
        }
        static int SqrEvenPositive(IEnumerable<int> myList)
        {
            IEnumerable<int> query = myList.Where(x => x % 2 == 0 && x > 0);
            return Sqr(query.ToList()); //запомни эту конструкцию
        }

        static int MiddleOfOdd (IEnumerable<int> myList)
        {
            IEnumerable<int> ml = myList.Where(x => x % 2 != 0 && x > -10);
            return ml.Sum() / ml.Count();
        }

        //Сортировка не пузырьком
        static IEnumerable<int> Sortt (IEnumerable<int> myList)
        {
            
            var ordered = myList.OrderBy(x => x);
            
            return ordered;
            
        }

        //поиск второго макс мин
        static int SecondMax (IEnumerable<int> myList)
        {
            IEnumerable<int> lst = myList.Where(x => x != myList.Max());
            return lst.Max();
        }

        static int SecondMin(IEnumerable<int> myList)
        {
            IEnumerable<int> lst = myList.Where(x => x != myList.Min());
            return lst.Min();
        }

        //поиск k-того мин макс
        static int KMax(IEnumerable<int> myList, int k) 
        {
            List<int> coll = Sortt(myList).ToList();
            int searched = coll[coll.Count - k];
            return searched;
        }
        static void Main(string[] args)
        {
            List<int> myList = new List<int> { 1, 5, 2, 7, 12, 98, 22, 4 };
            int k = 2;
            //Console.WriteLine(MiddleNum(myList));
            //Console.WriteLine(NearestToMiddle(myList));
            Console.WriteLine(string.Join(" ", Sortt(myList)));
            Console.WriteLine(KMax(myList, k)); 
        }
    }
}
