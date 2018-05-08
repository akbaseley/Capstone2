using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Anna_Baseley_Capstone_2
{
    class Validation
    {
        public static int UserSelection(string message)
        {
            Console.WriteLine(message);
            int select = int.Parse(Console.ReadLine());

            while (select < 1 || select > 5)
            {
                Console.WriteLine("I'm sorry." + message + "Please enter the number.");
                select = int.Parse(Console.ReadLine());
            }

            return select;
        }

        public static string ValidateNewTask(string message)
        {
            Console.Write(message);
            string newTask = Console.ReadLine();
            return newTask;
        }

        public static DateTime ValidateDueDate(string message, string regex)
        {
            Console.Write(message);
            string newTask = Console.ReadLine();

            while (!Regex.IsMatch(newTask, regex))
            {
                Console.WriteLine("I'm sorry. I need a due date." + message);
                newTask = Console.ReadLine();
            }
            return DateTime.Parse(newTask);
        }

        public static int GetIndex(string message, int taskCount)
        {
            Console.WriteLine(message);
            int deletion = int.Parse(Console.ReadLine());
            while (deletion < 1 || deletion > taskCount)
            {
                Console.WriteLine("Invalid Input. " + message);
                deletion = int.Parse(Console.ReadLine());
            }
            return deletion-1;
        }

        public static string UserContinue(string message)
        {
            Console.WriteLine(message);
            string Response = Console.ReadLine().ToLower();

            while(Response != "n" && Response != "y")
            {
                Console.WriteLine("What was that? " + message);
                Response = Console.ReadLine();
            }
            return Response;
        }

    }
}
