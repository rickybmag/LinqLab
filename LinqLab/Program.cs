using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            Console.WriteLine("----- Numbers Questions -----");

            //1) Min Value
            int minValue = nums.Min();
            Console.WriteLine("Minimum value: " + minValue);
            Console.WriteLine();

            //2) Max Value
            int maxValue = nums.Max();
            Console.WriteLine("Maximum value: " + maxValue);
            Console.WriteLine();

            //3) Find the Maximum value less than 10000
            int lessThan10000 = nums.Where(x => x < 10000).Max();
            Console.WriteLine("Max value less than 10000: " + lessThan10000);
            Console.WriteLine();

            //4) Find all the values between 10 and 100
            List<int> nums10To100 = nums.Where(x => x < 100 && x > 10).ToList();
            Console.WriteLine("Numbers between 10 and 100: ");
            foreach(int n in nums10To100)
            {
                //Will be blank because there aren't any numbers in that range
                Console.WriteLine(n);
            }
            Console.WriteLine();

            //5) Find all the Values between 100000 and 999999 inclusive
            List<int> nums100KTo999K = nums.Where(x => x >= 100000 && x <= 999999).ToList();
            Console.WriteLine("Numbers between 100k and 999k: ");
            foreach(int n in nums100KTo999K)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
                     

            //6)  Count all the even numbers
            List<int> evenNums = nums.Where(x => x % 2 == 0).ToList();
            Console.WriteLine("All even numbers: ");
            foreach(int n in evenNums)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            Console.WriteLine("----- Student Questions -----");

            //1)  Find all students age of 21 and over
            List<Student> drinkingAge = students.Where(x => x.Age >= 21).ToList();
            Console.WriteLine("Students over 21: ");
            foreach(Student s in drinkingAge)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();

            //2) Find the oldest student
            int oldest = students.Max(x => x.Age);
            List<Student> oldestStudent = students.Where(x => x.Age == oldest).ToList();
            Console.WriteLine("Oldest student: " );
            foreach(Student s in oldestStudent)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();

            //3)Find the youngest student
            int youngest = students.Min(x => x.Age);
            List<Student> youngestStudent = students.Where(x => x.Age == youngest).ToList();
            Console.WriteLine("Youngest student: ");
            foreach(Student s in youngestStudent)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();

            //4) Find the oldest student under the age of 25
            List<Student> under25 = students.Where(x => x.Age < 25).ToList();
            int oldestUnder25 = under25.Max(x => x.Age);
            List<Student> oldest25 = students.Where(x => x.Age == oldestUnder25).ToList();
            Console.WriteLine("Oldest student(s) under 25: ");
            foreach(Student s in oldest25)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();

            //5) Find all students over 21 and with even ages
            List<Student> over21 = students.Where(x => x.Age > 21 && x.Age % 2 == 0).ToList();
            Console.WriteLine("Student(s) over 21 but with even ages");
            foreach(Student s in over21)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();

            //6) Find all teenage students (13 to 19 inclusive)
            List<Student> teenageStudents = students.Where(x => x.Age >= 13 && x.Age <= 19).ToList();
            Console.WriteLine("Student(s) with ages from 13 to 19: ");
            foreach(Student s in teenageStudents)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();

            //7) Find all students whose name starts with a vowel
            List<Student> vowelNames = students.Where(x => x.Name.StartsWith('A') || x.Name.StartsWith('E') || x.Name.StartsWith('I') || x.Name.StartsWith('O') || x.Name.StartsWith('U')).ToList();
            Console.WriteLine("Student(s) with name(s) beginning with a vowel: ");
            foreach(Student s in vowelNames)
            {
                Console.WriteLine(s.Name);
            }

        }
    }
}
