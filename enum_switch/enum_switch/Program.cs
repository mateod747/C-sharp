using System;
using System.Collections.Generic;

namespace enum_switch_lesson
{
    class Program
    {
        class Todo
        {
            public string Description { get; set; }
            public int EstimatedHours { get; set; }
            public Status Status { get; set; }
        }
        enum Status
        {
            NotStarted,
            InProgress,
            OnHold,
            Completed,
            Deleted
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            List<Todo> todos = new List<Todo>()
            {
                new Todo { Description = "Clean da houz", EstimatedHours = 2, Status = Status.Completed },
                new Todo { Description = "Repair the toilet sink", EstimatedHours = 1, Status = Status.OnHold },
                new Todo { Description = "Play ps4", EstimatedHours = 6, Status = Status.InProgress },
                new Todo { Description = "Go out with friends", EstimatedHours = 2, Status = Status.NotStarted },
                new Todo { Description = "Study", EstimatedHours = 4, Status = Status.OnHold }
            };

            foreach (Todo todo in todos)
            {
                Console.WriteLine("{0} est.:{1} completed?:{2}", todo.Description, todo.EstimatedHours, todo.Status);
            }

            foreach (Todo todo in todos)
            {
                switch (todo.Status)
                {
                    case Status.Completed:
                        Console.WriteLine("Completed!");
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Beep();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Not completed!");
                        Console.Beep();
                        Console.Beep();
                        break;
                }
            }

        }
    }
}
