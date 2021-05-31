using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
          string[] colors = new string[5];
          string[] animals = {"Cat","Dog","Bird","Monkey"};

          int[] arr;
          arr = new int[5];

          colors[0] = "Blue";
          System.Console.WriteLine(animals[0]);
          arr[3] = 10;

          Console.WriteLine(animals[1]);
          Console.WriteLine(arr[3]);
          Console.WriteLine(colors[0]);

          //Arrays with loops
          //program that calculates the average of n numbers entered from the user
          Console.Write("Enter number of element for array: ");
          int arr_length = int.Parse(Console.ReadLine());
          int[] numArr = new int[arr_length];

          for (int i = 0; i < arr_length; i++)
          {
              Console.WriteLine("Lütfen {0}. sayıyı giriniz: ", i+1);
              numArr[i] = int.Parse(Console.ReadLine());
          }
          
          int sum = 0;
          foreach (var num in numArr)
              sum += num;
          Console.WriteLine("Average: " + sum/arr_length);
        }
    }
}
