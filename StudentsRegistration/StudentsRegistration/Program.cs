using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsRegistration
{
    internal class Program
    {
        static int nexId = 1;

        static void Main()
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                Student student = null;

                Read("Име: ", s => student = new Student(nexId, s));
                nexId++;

                Read("Възраст: ", s => student.Age = int.Parse(s));
                Read("Клас: ", s => student.Grade = int.Parse(s));
                Read("Среден успех: ", s => student.AverageScore = double.Parse(s));
                Read("Такса: ", s => student.Fee = decimal.Parse(s));
                Read("Стипендия (да/не): ", s => student.HasScholarship = YesOrNo(s));
                Read("Паралелка: ", s => student.ClassLetter = char.Parse(s));
                Read("Дата на раждане (дд.мм.гггг): ", s => student.BirthDate = DateTime.ParseExact(s, "dd.MM.yyyy", null));

                students.Add(student);

                Console.Write("Друг ученик? (да/не): ");
                if (Console.ReadLine().Trim().ToLower() != "да") break;
            }

            foreach (Student student in students)
            {
                Console.WriteLine();
                Console.WriteLine("=== ДАННИ ЗА УЧЕНИК ===");
                Console.WriteLine();
                Console.WriteLine("Id: " + student.Id);
                Console.WriteLine("Име: " + student.Name);
                Console.WriteLine("Възраст: " + student.Age);
                Console.WriteLine("Клас: " + student.Grade);
                Console.WriteLine("Среден успех: " + student.AverageScore.ToString("F2"));
                Console.WriteLine("Такса: " + student.Fee.ToString("F2") + " лв.");
                Console.WriteLine("Стипендия: " + (student.HasScholarship ? "Да" : "Не"));
                Console.WriteLine("Паралелка: " + student.ClassLetter);
                Console.WriteLine("Дата на раждане: " + student.BirthDate.ToString("dd.MM.yyyy"));
            }
        }


        static void Read(string prompt, Action<string> apply)
        {
            while (true)
            {
                Console.Write(prompt);
                try
                {
                    apply(Console.ReadLine());
                    return;
                }
                catch (Exception ex) when (ex is FormatException || ex is OverflowException)
                {
                    Console.WriteLine("Невалиден формат. Опитайте отново.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Грешка: " + ex.Message);
                }
            }
        }

        static bool YesOrNo(string s)
        {
            s = s.Trim().ToLower();
            if (s == "да") return true;
            if (s == "не") return false;
            throw new FormatException();
        }
    }
}
