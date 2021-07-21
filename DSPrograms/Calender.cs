using DSPrograms;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSPrograms
{
    public class Calendar
    {
        public static int month;
        public static int year;
        static string[] months = { "","Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec" };
        public static Queue<CalenderWeek<Calendar>> week = new Queue<CalenderWeek<Calendar>>();

        //Get input from user
        public void GetInput()
        {
            Console.WriteLine("Enter year of Calender");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month of Calender");
            month = Convert.ToInt32(Console.ReadLine());

            CalenderFormat();
        }
        public static int DayFromDate(int d, int m, int y)
        {
            //Gregorian calendar
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            return d0;
        }
        //Prints content of Calendar
        public void CalenderFormat()
        {
            int day = 1;
            int startDate = DayFromDate(1, month, year);
            int totalDays = DateTime.DaysInMonth(year, month);
            List<string> weeks = new List<string>() { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            for (int i = 1; i <= 6; i++)
            {
                //Create object for each day of a week
                CalenderWeek<Calendar> weekDayQueue = new CalenderWeek<Calendar>();
                for (int j = 0; j < 7 && day <= totalDays; j++)
                {
                    CalenderWeek<Calendar> calenderWeek;
                    //If date is empty ,this part is executed
                    if (i == 1 && j < startDate)
                    {
                        calenderWeek = new CalenderWeek<Calendar>(weeks[j], " ");
                        weekDayQueue.InsertLast(calenderWeek);
                        continue;
                    }
                    calenderWeek = new CalenderWeek<Calendar>(weeks[j], Convert.ToString(day));
                    //Store value of each weekDay object 
                    weekDayQueue.InsertLast(calenderWeek);
                    day++;
                }
                //Enqueue each week object
                week.Enqueue(weekDayQueue);
            }
            DisplayCalender();
        }

        //Display all days
        public void DisplayCalender()
        {
            Console.WriteLine("{0} year {1} month ", year, month);
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
            foreach (var i in week)
            {
                i.DisplayWeek();
            }
        }
    }
}


