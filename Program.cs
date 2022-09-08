using System.Linq.Expressions;

namespace Assignment3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an integar number between 0 and 100");
                int input = int.Parse(Console.ReadLine());

                if ((input >0) && (input <= 100))
                {

                    Console.WriteLine("Choose odd or even number:");
                    string series_name = Console.ReadLine();


                    if (series_name == "even")
                    {
                        int i = 1;
                        int even = 0;
                        do
                        {

                            Console.WriteLine(even.ToString() + " is an even number");
                            even = 2 * i;
                            i++;
                        }
                        while (even <= input);
                    }

                    else if (series_name == "odd")
                    {
                        int i = 1;
                        int odd = 0;
                        do
                        {

                            Console.WriteLine(odd.ToString() + " is an odd number");
                            odd = 2 * i + 1;
                            i++;
                        }
                        while (odd <= input);
                    }

                    else
                    {
                        Console.WriteLine("Select an option between even and odd");
                    }
                        Console.ReadKey(true);

                    }
                    else
                    {
                        Console.WriteLine("Please enter an integar between 0 and 100");
                    }


                }
               catch
            {
                Console.WriteLine("Please enter an integar and try again!");
                Console.ReadKey(false);
            }

            
    }   }
}