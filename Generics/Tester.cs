using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericsArray<T>
    {
        private T[] array;
        public GenericsArray(int size)
        {
            array = new T[size + 1];
        }

        public T getItems(int index)
        {
            return array[index];
        }

        public void setItems(int index, T value)
        {
            array[index] = value;
        }
    }


    class Tester
    {
        static void Main(string[] args)
        {
            //Create integer array
            GenericsArray<int> intArray = new GenericsArray<int>(10);

            //Set values
            for (int x = 0; x < 10; x++)
            {
                intArray.setItems(x, x * 2);
            }

            //Get the values
            for (int y = 0; y < 10; y++)
            {
                Console.Write(intArray.getItems(y) + " ");
            }

            Console.WriteLine();


            GenericsArray<char> charArray = new GenericsArray<char>(10);

            //Set values 
            for (int k = 0; k > 10; k++)
            {
                charArray.setItems(k, (char)(k + 2));
            }

            //Get values
            for (int t = 0; t < 10; t++)
            {
                Console.Write(charArray.getItems(t) + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
