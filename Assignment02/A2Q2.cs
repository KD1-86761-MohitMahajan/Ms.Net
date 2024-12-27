using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02Q2
{


    public struct Student
    {

        private string name;
        private bool gender;
        private int age;
        private int std;
        private char div;
        private double marks;

        public Student(bool gender, string name, int age, int std, char div, double marks)
        {
            this.gender = gender;
            this.name = name;
            this.std = std;
            this.age = age;
            this.div = div;
            this.marks = marks;

        }

        public string GetName() => name;
        public string SetName(string value) => name = value;



        public bool GetGender() => gender;
        public bool SetGender(bool value) => gender = value;

        public int GetAge() => age;
        public void SetAge(int value) => age = value;

        public int GetStd() => std;
        public void SetStd(int value) => std = value;

        public char GetDiv() => div;
        public void SetDiv(char value) => div = value;

        public double GetMarks() => marks;
        public void SetMarks(double value) => marks = value;

        public void AcceptDetails()
        {

            Console.WriteLine("Enter the name: ");
            SetName(Console.ReadLine());

            Console.WriteLine("Enter the age: ");
            SetAge(int.Parse(Console.ReadLine()));

            Console.WriteLine("Enter the gender (true for Male, false for Female): ");
            SetGender(bool.Parse(Console.ReadLine()));

            Console.WriteLine("Enter the Std: ");
            SetStd(int.Parse(Console.ReadLine()));

            Console.WriteLine("Enter the Division: ");
            SetDiv(Char.Parse(Console.ReadLine()));

            Console.WriteLine("Enter the Marks: ");
            SetMarks(int.Parse(Console.ReadLine()));


        }

        public void PrintDetails()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Gender: " + (gender ? "Male" : "Female"));
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Standard: " + std);
            Console.WriteLine("Division: " + div);
            Console.WriteLine("Marks: " + marks);
        }
    }

    class Program
    {

        static void CreateArray(ref Student[] students)
        {
            Console.WriteLine("Enter the Number of Students: ");
            int size = (int.Parse(Console.ReadLine()));

            students = new Student[size];

            Console.WriteLine("Array of size " + size + " created");

        }

        static void AcceptInfo(Student[] students)
        {

            Console.WriteLine("Enter Student Details: ");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"\nStudent {i + 1}:");
                students[i].AcceptDetails();
            }

        }

        static void PrintInfo(Student[] students)
        {
            Console.WriteLine("\nStudent details:");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"\nStudent {i + 1}:");
                students[i].PrintDetails();
            }
        }
        static void ReverseArray(Student[] students, ref Student[] reversedArray)
        {
            int size = students.Length;
            reversedArray = new Student[size];

            for (int i = 0; i < size; i++)
            {
                reversedArray[i] = students[size - 1 - i];
            }

            Console.WriteLine("\nArray has been reversed.");
        }

        static void Main(string[] args)
        {
            Student[] students = null;
            Student[] reversedArray = null;

            CreateArray(ref students);
            AcceptInfo(students);
            PrintInfo(students);

            ReverseArray(students, ref reversedArray);
            Console.WriteLine("\nReversed student details:");
            PrintInfo(reversedArray);
        }
    }
}
