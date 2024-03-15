using System;

public enum DaysOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

public class CalendarEvent
{
    public string EventName { get; set; }
    public DaysOfWeek EventDay { get; set; }

    public CalendarEvent(string eventName, DaysOfWeek eventDay)
    {
        EventName = eventName;
        EventDay = eventDay;
    }

    public void PrintEventDetails()
    {
        Console.WriteLine($"The event {EventName} will occur on {EventDay}\n");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        string eventName = "";
        while (eventName != "exit")
        {
            Console.WriteLine("Enter the event name (or 'exit' to quit):");
            eventName = Console.ReadLine();

            if (eventName != "exit")
            {
                Console.WriteLine("Select the event day:");
                foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
                {
                    Console.WriteLine($"{(int)day}. {day}");
                }
                int eventDayIndex = int.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(DaysOfWeek), eventDayIndex))
                {
                    DaysOfWeek eventDay = (DaysOfWeek)eventDayIndex;
                    CalendarEvent myEvent = new CalendarEvent(eventName, eventDay);
                    myEvent.PrintEventDetails();
                }
                else
                {
                    Console.WriteLine("Invalid event day selected.");
                }
            }
        }
    }
}