using System;
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = "";

    public string Course { get; set; } = "";

    public int Age { get; set; }
}
class Program
{
    static List<Student> students = new List<Student>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Student Management System ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Delete Student");
            Console.WriteLine("4. Exit");

            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;

                case 2:
                    ViewStudents();
                    break;

                case 3:
                    DeleteStudent();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }

    static void AddStudent()
    {
        Student s = new Student();

        Console.Write("Enter ID: ");
        s.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
       s.Name = Console.ReadLine() ?? "";

        Console.Write("Enter Course: ");
       s.Course = Console.ReadLine() ?? "";

        Console.Write("Enter Age: ");
        s.Age = Convert.ToInt32(Console.ReadLine());

        students.Add(s);

        Console.WriteLine("Student Added Successfully");
    }

    static void ViewStudents()
    {
        Console.WriteLine("\nStudents List:");

        foreach (var s in students)
        {
            Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Course: {s.Course}, Age: {s.Age}");
        }
    }

    static void DeleteStudent()
    {
        Console.Write("Enter Student ID to delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        students.RemoveAll(s => s.Id == id);

        Console.WriteLine("Student Deleted Successfully");
    }
}