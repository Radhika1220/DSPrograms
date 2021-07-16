
using System;

using System.Text;

namespace DSPrograms
{
    public class Calender
    { 
        public static void PrintCalender()
        { 
            //Print calendar

             Console.WriteLine("Please enter the year you want to print the calendar:");

             int year = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter the month : ");

             int month = Convert.ToInt32(Console.ReadLine());
            //Get the number of days in month
             int days = DateTime.DaysInMonth(year, month);
            //The first day of the month
             DateTime currday = new DateTime(year, month, 1);
            
             DateTime lastday = currday.AddMonths(1);

             Console.WriteLine();

             Console.WriteLine("{0} year {1} month ", year, month);

             Console.WriteLine("S\tM\tTu\tW\tThu\tF\tSat");
            //To print until next day of month
             while (currday < lastday)
                {
                int weekday = Convert.ToInt32(currday.DayOfWeek);

                    if (currday.Day == 1)
                    {
                        StringBuilder tmpSpace = new StringBuilder();
                        for (int j = 0; j < weekday; j++)
                         {
                            tmpSpace.Append("  \t");
                         }

                    Console.Write("{0} {1}", tmpSpace.ToString(), currday.Day);
                    }
                    //If it is sunday
                    else if (currday.DayOfWeek == DayOfWeek.Sunday)

                    {   
                        Console.Write(Environment.NewLine);

                        Console.Write(" {0}", currday.Day);

                    }
                    //For other days
                    else
                    {
                        Console.Write(" \t {0}", currday.Day);

                    }

                    currday = currday.AddDays(1);
                }
            }
        }
    }


