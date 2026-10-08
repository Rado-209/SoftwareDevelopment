using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopment
{
    internal class Problem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int endDate { get; set; }
        public Problem(string name, string description, int endDate)
        {
            Name = name;
            Description = description;
            this.endDate = endDate;
        }

        public List<Problem> Problems { get; set; } = new List<Problem>();




        public void AddProblem()
        {
            Console.WriteLine("Изберете име на задачата");
            string name = Console.ReadLine();
            Console.WriteLine("Изберете описание на задачата");
            string Description = Console.ReadLine();
            Console.WriteLine("Изберете краен срок на задачата");
            int endDate = int.Parse(Console.ReadLine());

            Problem problem = new Problem(name, Description, endDate);
            Problems.Add(problem);
        }

        public void ShowProb()
        {
            if (Problems == null)
            {
                Console.WriteLine("няма задачи");
                return;
            }
            foreach (Problem problem in Problems)
            {
                Console.WriteLine($"Име: {problem.Name}, Описание: {problem.Description}, Краен срок: {problem.endDate} дни");
            }

        }
        public void isComplete()
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

            Problem completedProblem = Problems[choice - 1];

            Problems.RemoveAt(choice - 1);

            Console.WriteLine($"Задачата '{completedProblem.Name}' е решена!");
        }

        public void DeleteProb()
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

            Problem DeletedProblem = Problems[choice - 1];

            Problems.RemoveAt(choice - 1);

            Console.WriteLine($"Задачата '{DeletedProblem.Name}' е изтрита!");

        }
    }
}