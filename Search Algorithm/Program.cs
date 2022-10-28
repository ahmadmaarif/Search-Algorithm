using System;

namespace SearchAlgorithm
{
    class Program
    {
        //Array to be searched
        int[] arr= new int[20];
        //Number of the elements in the array
        int i;
        int n;
        
        public void input()
        {
            while(true)
            {
                Console.Write("Enter the number of elements in the array:");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\n Array should have minumum 1And maximum 20 elements.\n");                
            }
            //Console array elements
            Console.WriteLine("");
            Console.WriteLine("____________________");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("____________________");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);

            }
        }
    }
}