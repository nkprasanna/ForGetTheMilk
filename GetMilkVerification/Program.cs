using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GetMilkVerification
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("\nAdd a task:\n");
                var input = Console.ReadLine();
                var task = new ForGetTheMilk.Controllers.TaskController.Task(input);

                Console.WriteLine("Description: "+ task.Description);
                Console.WriteLine("Due Date: "+ task.DueDate);
            }
        }
    }
}
