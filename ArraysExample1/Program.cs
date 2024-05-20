using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExample1
{
    internal class Program
    {
        static void Main()
        {
            //create the array
            int[] array1 = new int[5] {1,2,3,4,5};
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
            string[] array2 = new string[5] { "one", "two", "three", "four", "five" };
            for(int i=0;i<array2.Length;i++)
            {
                Console.WriteLine(array2[i]);
            }
            //display the array elements by using foreach loop
            foreach(int i in array1)
            {
                Console.WriteLine(i);
            }
            //reverse of array
            for(int i=array2.Length-1;i>=0;i--)
            {
                Console.WriteLine(array2[i]);
            }
            
            //search the element in the array
            int el=Array.IndexOf(array1, 3);
            Console.WriteLine("search the element 3 in the array : "+el);
           

            //search unknown value in the array
            int e2= Array.IndexOf(array1, 6);
            Console.WriteLine("search the element 6 in the array : "+e2);
           

            //search teh element using binary search
            int e3=Array.BinarySearch(array1, 4);
            Console.WriteLine("Search the element 4 using Ninary search : " + e3);

            //clear the element in the array
            Array.Clear(array2, 0,array2.Length);
            //resize the elements in the array
            int[] array3= new int[3] {1,2,3};
            Array.Resize(ref array3,5);
            foreach(int i in array3)
            {
                Console.WriteLine(i);
            }
         
            //sort the elements in teh array
            int[] array4 = new int[3] { 20, 10, 30 };
            Array.Sort(array4);
            foreach (int i in array4)
            {
                Console.WriteLine(i);
            }

            //Reverse the elements in the array
            Array.Reverse(array4);
            foreach(int i in array4)
                {
                Console.WriteLine(i);
            }

            //multi dimentional array
            Console.WriteLine("Multi Dimentional Array");
            

            int[,] array5 = new int[3,3] { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            for(int i=0;i<3;i++)
            {
                for (int j=0; j < 3;j++)
                {
                    Console.Write(array5[i,j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
