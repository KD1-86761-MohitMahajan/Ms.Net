using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Logging.StructuredLogger;

namespace Assignment02
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

        public void AcceptDetails() {

            Console.WriteLine("Enter the name: ");
            SetName(Console.ReadLine() ) ;

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
        static void Main(string[] args)
        {
            // Using the default constructor
            Student student1 = new Student();
            Console.WriteLine("Enter details for student 1:");
            student1.AcceptDetails();
            student1.PrintDetails();

            // Using the parameterized constructor
            Student student2 = new Student(true, "XXX", 18, 12, 'A', 55 );
            Console.WriteLine("\nDetails for student 2 (using parameterized constructor):");
            student2.PrintDetails();
        }
    }

}


