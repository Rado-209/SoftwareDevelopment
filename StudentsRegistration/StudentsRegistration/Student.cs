using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsRegistration
{
    internal class Student
    {
        private string name;
        private int age;
        private int grade;
        private double averageScore;
        private decimal fee;
        private char classLetter;
        private DateTime birthDate;
        public int Id { get; }

        public Student(int id, string name)
        {
            if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id), "Id трябва да е положително цяло число.");

            Id = id;
            Name = name;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null) throw new ArgumentException("Името не може да бъде празно.", nameof(value));
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 6 || value > 20) throw new ArgumentOutOfRangeException(nameof(value), "Възрастта трябва да бъде между 6 и 20 години.");
                age = value;
            }
        }

        public int Grade
        {
            get { return grade; }
            set
            {
                if (value < 1 || value > 12) throw new ArgumentOutOfRangeException(nameof(value), "Класът трябва да бъде между 1 и 12.");
                grade = value;
            }
        }

        public double AverageScore
        {
            get { return averageScore; }
            set
            {
                if (value < 2.00 || value > 6.00) throw new ArgumentOutOfRangeException(nameof(value), "Средният успех трябва да бъде между 2.00 и 6.00.");
                averageScore = value;
            }
        }

        public decimal Fee
        {
            get { return fee; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(value), "Таксата не може да бъде отрицателна.");
                fee = value;
            }
        }

        public bool HasScholarship { get; set; }

        public char ClassLetter
        {
            get { return classLetter; }
            set
            {
                if (!char.IsLetter(value)) throw new ArgumentException("Паралелката трябва да бъде буква.", nameof(value));
                classLetter = value;
            }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                if (value > DateTime.Today) throw new ArgumentOutOfRangeException(nameof(value), "Датата на раждане не може да бъде бъдеща.");
                birthDate = value;
            }
        }
    }
}
