using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anna_Baseley_Capstone_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string format = "MM/dd/yyyy";
            List<Task> taskList = new List<Task>();

            taskList.Add(new Task("Steven", "Debug Lab 11", DateTime.Parse("05/10/2018")));
            taskList.Add(new Task("Joe", "Code Lab 12", DateTime.Parse("05/12/2018")));
            taskList.Add(new Task("Jack", "Submit Lab 10", DateTime.Parse("05/8/2018")));
            taskList.Add(new Task("Amy", "Start Lab 14", DateTime.Parse("05/11/208")));
            taskList.Add(new Task("Susan", "Debut Lab 9", DateTime.Parse("05/5/2018")));

            Console.WriteLine("Welcome to the GC Task Manager!");

            bool KeepGoing = true;

            while (KeepGoing)
            {
                int taskCount = taskList.Count;

                Console.WriteLine($"{"1.",5} {"List tasks"}");
                Console.WriteLine($"{"2.",5} {"Add task"}");
                Console.WriteLine($"{"3.",5} {"Delete task"}");
                Console.WriteLine($"{"4.",5} {"Mark task complete"}");
                Console.WriteLine($"{"5.",5} {"Quit"}");

                int TaskSelection = Validation.UserSelection("What would you like to do? ");

                if (TaskSelection == 1)
                {
                    Console.WriteLine($"{"", 5}{"Complete?",-10} {"Due Date",-14} {"TeamMember",-10} {"Description"}");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine($"{i+1,-5}{taskList[i].Completion,-10} {taskList[i].DueDate.ToString(format),-14} {taskList[i].TeammatesName,-10} {taskList[i].Description}");
                    }
                    KeepGoing = true;
                }
                else if (TaskSelection == 2)
                {
                    taskList.Add(new Task(Validation.ValidateNewTask("Team Member name: "), Validation.ValidateNewTask("Task Description: "), Validation.ValidateDueDate("Due Date: ", @"^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]\d{4}$")));
                    KeepGoing = true;
                }
                else if (TaskSelection == 3)
                {
                    int deleteTask = Validation.GetIndex("Which task would you like to delete?", taskCount);

                    Console.WriteLine($"{deleteTask+1, -5}{taskList[deleteTask].Completion, -10}{taskList[deleteTask].DueDate.ToString(format), -14} {taskList[deleteTask].TeammatesName, -10} {taskList[deleteTask].Description}");

                    string Response = Validation.UserContinue("Would you like to delete this task? y/n");
                    if (Response == "y")
                    {
                        taskList.Remove(taskList[deleteTask]);
                        KeepGoing = true;
                    }
                    else
                    {
                        KeepGoing = true;
                    }
                }
                else if (TaskSelection == 4)
                {
                    int completeTask = Validation.GetIndex("Which task would you like to mark 'complete'?", taskCount);
                    Console.WriteLine($"{completeTask+1,-5}{taskList[completeTask].Completion,-10}{taskList[completeTask].DueDate.ToString(format),-14} {taskList[completeTask].TeammatesName,-10} {taskList[completeTask].Description}");
                    string Response = Validation.UserContinue("Would you like to mark this task complete?");
                    if (Response == "y")
                    {
                        taskList[completeTask].Completion = true;
                        KeepGoing = true;
                    }
                    else
                    {
                        KeepGoing = true;
                    }
                }
                else if (TaskSelection == 5)
                {
                    string Response = Validation.UserContinue("Are you sure you would like to quit? y/n");
                    if (Response == "y")
                    {
                        Console.WriteLine("Okay!  See you next time!");
                        return;
                    }
                    else
                    {
                        KeepGoing = true;
                    }

                }
            }
        }
    }
}
