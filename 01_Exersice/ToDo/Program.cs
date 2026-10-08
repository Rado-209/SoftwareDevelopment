using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopment
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Problem problem = new Problem("", "", 0);

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
                    problem.AddProblem();
                }
                else if (choice == 2)
                {
                    problem.ShowProb();
                }
                else if (choice == 3)
                {
                    problem.isComplete();
                }
                else if (choice == 4)
                {
                    problem.isComplete();
                }
                else if (choice == 5)
                {
                    ExitProgram();
                }
            }
        }

        static void ExitProgram()
        {
            Console.WriteLine("Довиждане!");
            Environment.Exit(0);
        }

    }


}

