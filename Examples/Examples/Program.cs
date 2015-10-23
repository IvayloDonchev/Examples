using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Util
    {
        public static int Min(params int[] paramList)
        {
           if (paramList == null || paramList.Length == 0)
            {
                throw new ArgumentException("Util.Min: not enough arguments");
            }
           int currentMin = paramList[0];
           foreach (int i in paramList)
            {
               if (i < currentMin)
                {
                    currentMin = i;
                }
            }
           return currentMin;
        }
        public static double Sum(params object[] paramList)
        {
            double s = 0.0;
            try {
                foreach (object x in paramList)
                    s += double.Parse(x.ToString());    //Голяма простотия, ама работи!
             }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return 0.0;
            }
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Util.Min(5,5,1,2,4));
            Console.WriteLine(Util.Min(5, 5, 1, 2, 4));
            Console.WriteLine(Util.Min(2, 7, 5, 24));
            Console.WriteLine(Util.Min(5, 4));
            Console.WriteLine(Util.Min(10));

            Console.WriteLine(Util.Sum(2, 3.5));
        }
    }
}
