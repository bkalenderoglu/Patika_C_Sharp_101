using System;

namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            /*try
            {

            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entered number: " +number);

            }
            catch (Exception ex) // shows error message if it is exist
            {
                
                Console.WriteLine("Error: " +ex.Message.ToString());
            }
            finally // runs in any situation
            {
                Console.WriteLine("Done...");
            }*/
            
            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-200000000000");
            }
            catch (ArgumentNullException ex)
            {
                
                Console.WriteLine("Entered value is null! Value cannot be null!");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Wrong data type!");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Entered value is less or greater than it should be!");
                Console.WriteLine(ex);
            }  
            finally
            {
                Console.WriteLine("Done");
            }          

        }
    }
}
