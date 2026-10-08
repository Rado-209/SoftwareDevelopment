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
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Възраст: ");
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    if (age > 19) Console.WriteLine("Невалидна възраст. Опитайте отново.");
                    else break;
                }
                else Console.WriteLine("Невалидна възраст. Опитайте отново.");
            }
            
            Console.Write("Клас на ученика: ");
            if (byte.TryParse(Console.ReadLine(), out byte Grade))
            {
                if (Grade > 12) Console.WriteLine("Невалиден клас.");
                else Console.WriteLine($"Клас на ученика: {Grade}");
            }
            else Console.WriteLine("Невалиден клас.");
            
            Console.Write("Среден успех: ");
            if (double.TryParse(Console.ReadLine(), out double AvgGrade))
            {
                if (AvgGrade > 6) Console.WriteLine("Невалидна оценка.");
                else Console.WriteLine($"Среден успех: {AvgGrade}");
            }
            else Console.WriteLine("Невалидна оценка.");
            
            Console.Write("Такса: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal Tax))
            {
                Console.WriteLine($"Такса: {Tax}");
            }
            else Console.WriteLine("Невалидна такса.");
            
            Console.Write("Получава ли стипендия: ");
            if (bool.TryParse(Console.ReadLine(), out bool hasScholarship))
            {
                Console.WriteLine($"{hasScholarship}");
            }
            Console.Write("Въведете буква на паралелката: ");
            if (char.TryParse(Console.ReadLine(), out char Class))
            {
                Console.WriteLine($"Буква на паралелката: {Class}");
            }
            else Console.WriteLine("Невалиден клас.");
            while (true)
            {
                Console.Write("Въведете дата на раждане: ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime BirthDay))
                {
                    break;
                }
                else Console.WriteLine("Невалидна дата. Опитайте отново.");
            }
        }
    }
}
