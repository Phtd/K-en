using System;
using System.Collections.Generic;

namespace Køen
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<ToDo> TrainingsList = new Queue<ToDo>();
            bool StuffToDo = false;
            while (!StuffToDo)
            {
                Console.Clear();

                bool Done;
                Console.WriteLine("=====================" +
                    "\n\nQueue Operations Menu\n\n" +
                    "=====================\n\n" +
                    "Press one of the following numbers\n" +
                    "1 Add activity to your to do list\n" +
                    "2 Remove current activity from you to do list\n" +
                    "3 To see the next activity on your to do list\n" +
                    "4 Show your training program\n" +
                    "5 To shut down the program");
                int choice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:

                        Done = false;
                        while (!Done)
                        {
                            Console.WriteLine("Add an activity to do to the list");
                            string activity = Console.ReadLine();
                            Console.WriteLine("And how many repetitions?");
                            int amount = Convert.ToInt32(Console.ReadLine());
                            TrainingsList.Enqueue(new ToDo() { Activity = activity, Amount = amount });
                            Console.WriteLine("Do you want to add more y or n ?");
                            string choose = Console.ReadLine();
                            if (choose == "n")
                            {
                                Done = true;
                            }
                        }

                        break;

                    case 2:
                        if (TrainingsList.Count == 0)
                        {
                            Console.WriteLine("Your list of activities to do is empty");
                            break;
                        }
                        else if (TrainingsList.Count != 0)
                        {
                            Done = false;
                            while (!Done)
                            {
                                TrainingsList.Dequeue();
                                Console.WriteLine("Do you want to remove the next acitivity your trainings list y or n?");
                                string choose = Console.ReadLine();
                                if (choose == "n")
                                {
                                    Done = true;
                                }
                            }
                        }
                        break;
                    case 3:
                        if (TrainingsList.Count == 0)
                        {
                            Console.WriteLine("Your list of activities to do is empty");
                        }
                        else if (TrainingsList.Count != 0)
                        {
                            Console.WriteLine("The next activity on your list is to " + TrainingsList.Peek().Activity + " " + TrainingsList.Peek().Amount);
                            Console.WriteLine("Press anything on the keyboard to continue");
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        if (TrainingsList.Count == 0)
                        {
                            Console.WriteLine("Your list of activities to do is empty");
                        }
                        else if (TrainingsList.Count != 0)
                        {
                            Console.WriteLine("Here is everything on your current trainings list");
                            foreach (ToDo toDo in TrainingsList)
                            {
                                Console.WriteLine(toDo.Activity + " " + toDo.Amount + " ");
                                Console.WriteLine("Press anything on the keyboard to continue");
                                Console.ReadKey();
                            }
                        }
                        break;
                    case 5:
                        StuffToDo = true;
                        break;

                }
            }
        }
    }
}
