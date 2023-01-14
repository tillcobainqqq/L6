using System;

namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Student first name: ");
                string studentFirstName = Console.ReadLine();

                Console.Write("Student last name: ");
                string studentLastName = Console.ReadLine();

                Console.Write("Student faculty number: ");
                string studentFacultyNumber = Console.ReadLine();

                Student student = new Student(studentFirstName, studentLastName, studentFacultyNumber);

                Console.WriteLine();

                Console.Write("Worker first name: ");
                string workerFirstName = Console.ReadLine();

                Console.Write("Worker last name: ");
                string workerLastName = Console.ReadLine();

                Console.Write("Worker week salary: ");
                double workerWeekSalary = double.Parse(Console.ReadLine());

                Console.Write("Worker work hours: ");
                double workerWorkHours = double.Parse(Console.ReadLine());

                Worker worker = new Worker(workerFirstName, workerLastName, workerWeekSalary, workerWorkHours);

                Console.WriteLine();
                Console.WriteLine(student + Environment.NewLine);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
