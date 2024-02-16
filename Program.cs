using System.Collections;
using System.Xml.Linq;
namespace prac1
{
   
   
    public class Program
    {
        static void Main(string[] args)
        {
           while(true)
            {
                Console.WriteLine("                                                                            ");
                Console.WriteLine("******************* WELCOME TO HOTEL RESERVATION PROGRAM *******************");
                reward rv = new reward();
                

                Console.WriteLine("Are you a Regular or Reward customer?");
                string customer = Console.ReadLine();


                try
                {
                    if (customer =="regular"||customer=="reward")
                    {
                        Console.WriteLine("enter lakewood Weekday price:");
                        int a = int.Parse(Console.ReadLine());

                        Console.WriteLine("enter lakewood weekend price:");
                        int b = int.Parse(Console.ReadLine());

                        Console.WriteLine("give rating to lakewood hotel");
                        int rating = int.Parse(Console.ReadLine());

                        Console.WriteLine("enter bridgewood Weekday price:");
                        int c = int.Parse(Console.ReadLine());

                        Console.WriteLine("enter bridgewood weekend price:");
                        int d = int.Parse(Console.ReadLine());

                        Console.WriteLine("give rating to bridgewood hotel");
                        int rating1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("enter ridgewood Weekday price:");
                        int e = int.Parse(Console.ReadLine());

                        Console.WriteLine("enter ridgewood weekend price:");
                        int f = int.Parse(Console.ReadLine());

                        Console.WriteLine("give rating to ridgwood hotel");
                        int rating2 = int.Parse(Console.ReadLine());

                        hotel h = new hotel(a, b, rating, c, d, rating1, e, f, rating2);

                        rv.rewardscustomer();
                    }
                    else
                    {
                        throw new invalidCustomer("Exception occured !..enter valid customer type...");
                    }
                }catch(invalidCustomer e)
                {
                    Console.WriteLine("enter integer value" + e.Message );
                }
                catch(FormatException e1)
                {
                    Console.WriteLine(e1.Message);
                }



            }



        }
    }
}

