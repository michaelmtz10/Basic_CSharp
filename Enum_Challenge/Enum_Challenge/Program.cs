using System;

namespace Enum_Challenge
{
    class Program
    {
        enum DaysoftheWeek // created a enum class
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }

        static void Main(string[] args)
        {

            // var for monday
            DaysoftheWeek Monday = DaysoftheWeek.monday;
            // var for tuesday
            DaysoftheWeek Tuesday = DaysoftheWeek.tuesday;
            // var for wednesday
            DaysoftheWeek Wednesday = DaysoftheWeek.wednesday;
            // var for thursday
            DaysoftheWeek Thursday = DaysoftheWeek.thursday;
            // var for friday
            DaysoftheWeek Friday = DaysoftheWeek.friday;
            // var for saturday
            DaysoftheWeek Saturday = DaysoftheWeek.saturday;
            // var for sunday
            DaysoftheWeek Sunday = DaysoftheWeek.sunday;

            Console.WriteLine("Type in the current day of the week, all in lowercase!"); // ask user to input day of the week
            string user_choice = Convert.ToString(Console.ReadLine()); // converted user input into string
                try
                {
                    DaysoftheWeek day;
                    if (Enum.TryParse<DaysoftheWeek>(Convert.ToString(user_choice), true, out day)) // if user input matches any string parsed from DaysotheWeek return to console that it is in fact the correct day.
                    {
                        Console.WriteLine("{0}, is the correct day!", day);

                    }
                    else
                    {
                        Console.WriteLine("That is incorrect"); // if user input is not within enum class console.writeline the following...
                    }
                }

                catch
                {
                    Console.WriteLine("Please enter an actual day of the week");
                }

                Console.ReadLine();
            
        }

    }        
                  
}

