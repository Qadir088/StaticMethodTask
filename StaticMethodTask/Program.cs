using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace StaticMethodTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[0];
            arr = arr.Add(1);
            arr = arr.Add(2);
            arr = arr.Add(3);
            arr = arr.Add(4);
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            Console.WriteLine("Answer: " + sum);
        }
    }

    public static class Extensions
    {
        public static int[] Add(this int[] array, int newItem)
        {
            int[] newArray = new int[array.Length + 1];
            Array.Copy(array, newArray, array.Length);
            newArray[array.Length] = newItem;
            return newArray;
        }
    }
}

