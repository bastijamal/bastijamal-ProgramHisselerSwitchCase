using System;
namespace CodeAcademy
{
	public class Student
	{
        //Student student1 = new Student();

        public int Id { get; set; }
        public string Fullname { get; set; }
        public double Point { get; set; }


        public Student(int id, string fullname, double point)
        {
            Id = id;
            Fullname = fullname;
            Point = point;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"Student Id: {Id} , Student Fullname: {Fullname},  Student Point: {Point}");
        }
    }
}

