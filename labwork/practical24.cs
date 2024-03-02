using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string name { get; set; }
    public int rollno { get; set; }
    public int age { get; set; }
    public string address { get; set; }
    public string faculty { get; set; }

    public Student(string name, int rollno, int age, string address, string faculty)
    {
        this.name = name;
        this.rollno = rollno;
        this.age = age;
        this.address = address;
        this.faculty = faculty;
    }

    public static void Display(IEnumerable<Student> students)
    {
        foreach (var std in students)
        {
            Console.WriteLine("The student is : " + std.name);
            Console.WriteLine("The student roll no is : " + std.rollno);
            Console.WriteLine("The student age is : " + std.age);
            Console.WriteLine("The student address is : " + std.address);
            Console.WriteLine("The student faculty is : " + std.faculty + "\n");
        }
    }

    public static void Main(string[] args)
    {
        List<Student> stu = new List<Student>();
        stu.Add(new Student("rudal", 15, 21, "bharatpur", "bca"));
        stu.Add(new Student("aakash", 1, 22, "gaidakot", "bim"));
        stu.Add(new Student("basanta", 10, 25, "kathmandu", "csit"));
        stu.Add(new Student("pratik", 8, 20, "bharatpur", "csit"));
        stu.Add(new Student("lalit", 8, 20, "kathmandu", "bca"));

        //students who are from bca 
        var result1 = from student in stu
                      where student.faculty == "bca"
                      select student;
        var result2 = from student in stu
                      where student.faculty == "csit" && student.address == "kathmandu"
                      select student;
        Console.WriteLine("\nThe student from bca are:\n");
        Display(result1);
        Console.WriteLine("\nThe student from csit whoose address is kathmandu are:\n");
        Display(result2);
    }
}
