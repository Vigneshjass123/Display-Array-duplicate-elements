using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_Array_duplicate_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5,6,7,8,9, 1, 2, 3 };
            
            for(int i =0;i<arr.Length;i++)

            {
                for(int j =i+1;j<arr.Length;j++)
                {
                    if (arr[i] == arr[j])
                    {


                        Console.Write(arr[i]);
                    }
                   
                }
            }
            Console.ReadLine();
        }
    }
}
