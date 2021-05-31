using System;

namespace array_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] numArr = {23,12,4,86,72,3,11,17};

            Console.WriteLine("*** Unsorted Array ***");
            foreach (var num in numArr)
                Console.WriteLine(num);

            Console.WriteLine("*** Sorted Array ***");
            Array.Sort(numArr);
            foreach (var num in numArr)
                Console.WriteLine(num);  

            //Clear
            Console.WriteLine("*** Array Clear ***"); 
            //Starting from second index, set 2 value to zero.
            Array.Clear(numArr,2,2);

            foreach (var num in numArr)
                Console.WriteLine(num); 

            //Reverse
            Console.WriteLine("*** Array Reverse ***");
            Array.Reverse(numArr);

            foreach (var num in numArr)
                Console.WriteLine(num);  

            //IndexOf                    
            Console.WriteLine("*** Array IndexOf ***");
            Console.WriteLine(Array.IndexOf(numArr,86));

            //Resize
            Console.WriteLine("*** Array Resize***");
            Array.Resize<int>(ref numArr,9);
            numArr[8] = 99;

            foreach (var num in numArr)
                Console.WriteLine(num);
        }
    }
}
