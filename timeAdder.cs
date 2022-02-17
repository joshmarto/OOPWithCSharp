using System;

namespace timeAdder
{
    class Program
    {
        static TimeSpan convert(int time, string label)
        {
            switch (label)
            {
                case "seconds":
                    {
                        return new TimeSpan(0, 0, time);
                    }
                case "minutes":
                    {
                        return new TimeSpan(0, time, 0);
                    }
                case "hours":
                    {
                        return new TimeSpan(time, 0, 0);
                    }
                case "days":
                    {
                        return new TimeSpan(time, 0, 0, 0);
                    }
                case "second":
                    {
                        return new TimeSpan(0, 0, time);
                    }
                case "minute":
                    {
                        return new TimeSpan(0, time, 0);
                    }
                case "hour":
                    {
                        return new TimeSpan(time, 0, 0);
                    }
                case "day":
                    {
                        return new TimeSpan(time, 0, 0, 0);
                    }
                default:
                    {
                        return new TimeSpan(0);
                    }
            }
        }
        static string reverse(TimeSpan time)
        {
            string label="";
            if (time.Days > 1)
            {
                label = "Days";
            }
            else if (time.Days == 1)
            {
                label = "Day";
            }
            else if (time.Hours < 24)
            {
                label = "Hours";
            }
            else if (time.Hours == 1)
            {
                label = "Hour";
            }
            else if (time.Minutes > 1)
            {
                label = "Minutes";
            }
            else if (time.Minutes == 1)
            {
                label = "Minute";
            }
            else if (time.Seconds > 1)
            {
                label = "Seconds";
            }
            else if (time.Seconds == 1)
            {
                label = "Second";
            }
            return label;
        }
        static void timeAdder(int value1, string label1, int value2, string label2)
        {
            TimeSpan time1 = convert(value1, label1);
            TimeSpan time2 = convert(value2, label2);
            TimeSpan time = time1.Add(time2);
            Console.WriteLine(time.ToString() + " " + reverse(time));
        }
        static void Main(string[] args)
        {
            timeAdder(3, "hours", 70, "minutes");
        }
    }
}
