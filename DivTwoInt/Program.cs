using System;

namespace DivTwoInt
{
    class Program
    {
        static void Main(string[] args)
        {
            long d = -20; 
            long div = 7;
            // part 1
            long sign = (d < 0) ^ (div < 0) ? -1 : 1;

            // part 2
            long divident = Math.Abs(d);
            long divisor = Math.Abs(div);

            // part 3
            long reminder = 0;
            while ( divident>=divisor)
            {
                divident= divident - divisor;
                reminder++;
            }
            reminder = sign * reminder;
            // part 3
            Console.WriteLine(reminder);
        }
    }
}
