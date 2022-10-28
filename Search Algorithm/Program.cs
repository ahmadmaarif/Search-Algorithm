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
        public void BinarySearch()
        {
            char ch;
            do
            {
                //accept the number to be searched
                Console.WriteLine("\nEnter elementwant you to search : ");
                int item = Int32.Parse(Console.ReadLine());

                //apply binery search
                int lowerbound = 0;
                int upperbound = n - 1;

                //obtain the index of the elements in the array
                int mid = (lowerbound + upperbound) / 2;
                int ctr     = 1;

                //loop the search for the elements in the array
                while ((item != arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;

                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() + "found at position" + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + "not found in the array\n");
                Console.WriteLine("\nNumber of comprasion: " + ctr);

                Console.WriteLine("\nContinue search (y/n):");
                ch = char.Parse(Console.ReadLine());   


             
            } while ((ch == 'y') ||(ch =='Y')) ;
        }
        public void LinearSeacrh()
        {
            char ch;
            //search for number of comaprison
            int ctr;
            do
            {
                // accept the number to the search
                Console.Write("\nEnter the elements you want to search: ");
                int item = Convert.ToInt32(Console.ReadLine());

                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (arr[i] == item)
                    {
                        Console.WriteLine("\n" + item.ToString() + "found st position" + (i + 1).
                            ToString());
                        break;
                    }
                }
                if (i == n)
                    Console.WriteLine("\n" + item.ToString() + "not found in the array");
                Console.WriteLine("\nNumber of comparison:" + ctr);
                Console.WriteLine("\nContinue search (y/n");
                ch = char.Parse(Console.ReadLine());

            } while ((ch == 'y') || (ch == 'Y'));
        }
        

    }
}