using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopment
{
    public class TodoItem()
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EndDate { get; set; }
         
        public TodoItem() { }
        public TodoItem(int id, string name, string description, DateTime endDate)
        {
            Id = id;
            Name = name;
            Description = description;
            EndDate = endDate;
        }
    }

    internal class Program
    {
        private static List<TodoItem> Problems { get; set; } = new List<TodoItem>();
        private static int nextId = 1;

        static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. Добави задача");
                Console.WriteLine("2. Покажи задачи");
                Console.WriteLine("3. Маркирай задача като готова");
                Console.WriteLine("4. Изтрий задача");
                Console.WriteLine("5. Изход");
                Console.WriteLine();

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    AddProblem();
                }
                else if (choice == 2)
                {
                    ShowProb();
                }
                else if (choice == 3)
                {
                    isComplete();
                }
                else if (choice == 4)
                {
                    DeleteProb();
                }
                else if (choice == 5)
                {
                    ExitProgram();
                }
            }
        }
        static void AddProblem()
        {
            Console.Clear();
            Console.WriteLine("=====  Добавяне на задача =======");
            Console.Write("Заглавие:");
            string title = Console.ReadLine();

            Console.Write("Описание:");
            string description = Console.ReadLine();

            Console.Write("Краен срок:");
            DateTime dueDate = DateTime.Parse(Console.ReadLine());

            //TodoItem todoItem = new TodoItem(nextId, title, description, dueDate);

           // Problems.Add(todoItem);
            nextId++;
            Console.WriteLine("Задачата е добавена.");
        }
        static void ExitProgram()
        {
            Console.WriteLine("Довиждане!");
            Environment.Exit(0);
        }
        static void ShowProb()
        {
            if (Problems == null)
            {
                Console.WriteLine("няма задачи");
                return;
            }
            foreach (TodoItem todoitem in Problems)
            {
                Console.WriteLine($"Име: {todoitem.Name}, Описание: {todoitem.Description}, Краен срок: {todoitem.EndDate} дни");
            }

        }
        static void isComplete()
        {
            if (Problems.Count == 0)
            {
                Console.WriteLine("Няма задачи.");
                return;
            }

            Console.WriteLine("Изберете задачата:");

            for (int i = 0; i < Problems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Problems[i].Name}");
            }

            int choice = int.Parse(Console.ReadLine());

            if (choice < 1 || choice > Problems.Count)
            {
                Console.WriteLine("Невалиден избор.");
                return;
            }

            TodoItem completedProblem = Problems[choice - 1];

            Problems.RemoveAt(choice - 1);

            Console.WriteLine($"Задачата '{completedProblem.Name}' е решена!");
        }

        static void DeleteProb()
        {

            if (Problems.Count == 0)
            {
                Console.WriteLine("Няма задачи.");
                return;
            }

            Console.WriteLine("Изберете задачата:");

            for (int i = 0; i < Problems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Problems[i].Name}");
            }

            int choice = int.Parse(Console.ReadLine());

            if (choice < 1 || choice > Problems.Count)
            {
                Console.WriteLine("Невалиден избор.");
                return;
            }

            TodoItem DeletedProblem = Problems[choice - 1];

            Problems.RemoveAt(choice - 1);

            Console.WriteLine($"Задачата '{DeletedProblem.Name}' е изтрита!");

        }

    }


}

