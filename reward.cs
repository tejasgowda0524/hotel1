using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace prac1
{
    public class reward
    {
        public void rewardscustomer()
        {


            try
            {
                Console.WriteLine("Enter date range to book hotels (format: dd/MM/yyyy,dd/MM/yyyy):");
                string input = Console.ReadLine();

              
                string pattern = "[0-9]{1,2}[/]{1}[0-9]{1,2}[/]{1}[0-9]{4}";

                Dictionary<int, string> l = new Dictionary<int, string>();

                if (Regex.IsMatch(input, pattern))
                {
                    string[] dateRange = input.Split(',');

                    foreach (string dateStr in dateRange)
                    {
                        DateTime date = DateTime.ParseExact(dateStr.Trim(), "dd/MM/yyyy", null);

                        if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
                        {
                            l.Add(hotel.lakewoodWeekend, "lakewood");
                            l.Add(hotel.bridgewoodWeekend, "bridgewood");
                            l.Add(hotel.ridgewoodWeekend, "ridgewood");
                        }
                        else
                        {
                            l.Add(hotel.lakewoodWeekday, "lakewood");
                            l.Add(hotel.bridgewoodWeekday, "bridgewood");
                            l.Add(hotel.ridgewoodWeekday, "ridgewood");
                        }

                        Console.WriteLine("Do you want to book hotels based on their rating? (Yes/No)");
                        string isOkey = Console.ReadLine();

                        if (isOkey.ToLower() == "yes")
                        {
                            Console.WriteLine($"Enter the rating you prefer: {hotel.lakewoodRating}, {hotel.bridgewoodRating}, {hotel.ridgewoodRating}");
                            int rating = int.Parse(Console.ReadLine());

                            string hotelName = "";
                            int hotelRate = 0;

                            if (rating == hotel.lakewoodRating)
                            {
                                hotelName = "Lakewood";
                                hotelRate = date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday ? hotel.lakewoodWeekend : hotel.lakewoodWeekday;
                            }
                            else if (rating == hotel.bridgewoodRating)
                            {
                                hotelName = "Bridgewood";
                                hotelRate = date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday ? hotel.bridgewoodWeekend : hotel.bridgewoodWeekday;
                            }
                            else if (rating == hotel.ridgewoodRating)
                            {
                                hotelName = "Ridgewood";
                                hotelRate = date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday ? hotel.ridgewoodWeekend : hotel.ridgewoodWeekday;
                            }

                            Console.WriteLine($"Best hotel is {hotelName}\nHotel rate: {hotelRate}\nRating: {rating}");
                        }
                        else
                        {
                            int minval = l.Keys.Min();

                            Console.WriteLine("Total rate: " + minval + " \nBest hotel is " + l[minval]);
                            string hotelname = l[minval];

                            if (hotelname == "lakewood")
                            {
                                Console.WriteLine("Rating is : " + hotel.lakewoodRating);
                            }
                            else if (hotelname == "bridgewood")
                            {
                                Console.WriteLine("Rating is : " + hotel.bridgewoodRating);
                            }
                            else
                            {
                                Console.WriteLine("Rating is : " + hotel.ridgewoodRating);
                            }
                        }
                    }
                }
                else
                {
                    throw new invalidDateException("Invalid date range format. Please use the format: dd/MM/yyyy,dd/MM/yyyy");
                }
            }catch(invalidDateException e2)
            {
                Console.WriteLine(e2.Message);
            }






        }
    }

}

    

