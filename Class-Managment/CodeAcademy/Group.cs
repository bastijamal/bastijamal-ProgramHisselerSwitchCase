using System;
namespace CodeAcademy
{
	public class Group
	{


        private Student[] students;


        public string GroupNo { get; set; }

        private int _studentlimit;

        public int StudentLimit { get { return _studentlimit; }
            set {
                if (value>5 && value<18)
                {
                     _studentlimit=value;
                }
            }
        }


        public Group(int studentlimit,string groupno)

        //ps: GroupNo və StudentLimit dəyərləri olmadan Group Obyekti yaratmaq olmaz.
        {
            StudentLimit = studentlimit;
            GroupNo = groupno;
            //students = new Student[StudentLimit];   // baxarsan

        }


        public bool CheckGroupNo(string groupNo)
        {
            return groupNo.Length == 5 && char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]) && char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]);
        }


        public void AddStudent(Student student)
        {
            if (StudentLimit <= students.Length)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1]=student;

                ////baaaaaxxxxxx
            }

            else
            {
                Console.WriteLine("dogru deyil da beee Limit dogru doyull");
            }
        }


        public void GetAllStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

        }


        //- GetStudent() - parametr olaraq nullable int tipindən bir id dəyəri alacaq və həmin id-li Student obyektini tapıb geriyə qaytaracaq.

        //public Student GetStudent(Student[] stuudents, int id)
        //{


        //    if (id == null || students == null || students.Length == 0)
        //    {
        //        return null;
        //    }

        //    else
        //    {

        //    }










        }




    }


