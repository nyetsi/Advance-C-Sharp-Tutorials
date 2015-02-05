using System;
using System.Collections.Generic;


namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary
            Dictionary<string, string> valuesToAdd = new Dictionary<string, string>
            {
                {"Name","Vusi"},
                {"Age","25"}
            };


            foreach(KeyValuePair<string, string> key in valuesToAdd){
                Console.WriteLine("{0}: {1} ", key.Key, key.Value);
            }
            Console.ReadKey();
        }
    }
}
