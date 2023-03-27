using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemovevaluefromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.RemoveFromArray1();
            Console.WriteLine(Environment.NewLine);
            obj.RemoveFromArray2();
            Console.ReadLine();
        }

        public void RemoveFromArray1()
        {
            int[] numbers = { 1, 3, 4, 9, 2 };
            foreach (var item in numbers)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine(Environment.NewLine);
            int numToRemove = 9;
            int nLength = numbers.Length;

            // Search x in array
            int i;
            for (i = 0; i < nLength; i++)
            {
                if (numbers[i] == numToRemove)
                    break;
            }

            // If x found in array
            if (i < nLength)
            {
                // reduce size of array and
                // move all elements on space ahead
                for (int j = i; j < nLength - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }
            }

            Array.Resize(ref numbers, numbers.Length - 1);

            foreach (var item in numbers)
            {
                Console.Write(item + ", ");
            }
        }
        public void RemoveFromArray2()
        {
            int[] numbers = { 1, 3, 4, 9, 2 };
            foreach (var item in numbers)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine(Environment.NewLine);
            int numToRemove = 9;
            numbers = numbers.Where(val => val != numToRemove).ToArray();
            foreach (var item in numbers)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
