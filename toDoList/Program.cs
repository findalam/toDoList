using System;
using System.Collections.Generic;

namespace toDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            toDoList();
        }





        static void toDoList()
        {
            Console.WriteLine("Welcome to the TO DO LIST PROGRAM");
            List<string> taskList = new List<string>();
            string option = "";
            while (true)
            {
                Console.WriteLine("What would you like to do today?");
                Console.WriteLine("Enter 1 to add a task to the list\n Enter 2 to remove a task from the list\n Enter 3 to view the list\n Enter e to exit the To DO LIST program");

                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Please enter the task name to add to the list.");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("The task added to the list");
                }
                else if (option == "2")
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + " : " + taskList[i]);
                    }

                    Console.WriteLine("Please enter the number of task to remove from the list.");

                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(taskNumber);
                }
                else if (option == "3")
                {
                    Console.WriteLine("Current tasks in the list :");

                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(taskList[i]);
                    }

                }
                else if (option == "e")
                {
                    Console.WriteLine("Exiting the program");
                }
                else
                {
                    Console.WriteLine("Invalid Option, please try again.");
                }
                Console.WriteLine("Thank you for using to do list program.");

            }
        }
    }



}
