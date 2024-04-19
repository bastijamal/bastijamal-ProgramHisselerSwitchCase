using System;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeAcademy;

class Program
{
    static void Main(string[] args)
    {


        #region

        //        Student class
        //- Id
        //- Fullname
        //- Point
        //- StudentInfo() - Student-in bütün məlumatlarını ekrana console-a yazdırır

        //Group class
        //- GroupNo
        //- StudentLimit - qrupda ola biləcək tələbə sayını göstərir minumum 5 maximum 18 ola bilər.
        //- Students - Student tipindən bir array-dir özündə student obyektləri saxlayacaq və private olacaq.

        //- CheckGroupNo() - parametr olaraq string bir groupNo dəyəri alır və qrupun nömrəsini yoxlayır geriyə true/false dəyərləri qaytarır.
        //   Şərtlər: 2 böyük hərf əvvəldə və 3 rəqəmdən ibarət olmalıdır
        //- AddStudent() - parametr olaraq Student obyekti qəbul edir və gələn student obyektini Group class-ında olan Students arrayinə əlavə edir
        //əgər arrayin uzuluğu StudentLimit-i keçirsə əlavə etməməlidi.
        //- GetStudent() - parametr olaraq nullable int tipindən bir id dəyəri alacaq və həmin id-li Student obyektini tapıb geriyə qaytaracaq.
        //- GetAllStudents() - geriyə Student arrayi qaytaracaq.


        //ps: GroupNo və StudentLimit dəyərləri olmadan Group Obyekti yaratmaq olmaz.


        ///----------------------------------------------------------------------------------------------


        //        Program class
        //Program run olduqda:
        //1) Bir user yaradılmalıdı bunun üçün console-dan user-in bütün dəyərləri götürülüb yeni bir user yaradılır.
        //2) Bir menu gəlir:
        //        1. Show info
        //        2. Create new group

        //Əgər console-dan 1 göndərilsə user-in bütün məlumatları ekrana çıxmalıdı,
        //2 göndərildiyi halda console-dan group-un bütün məlumatları göndərilməli və yeni bir qrup obyekti yaradılmalıdır.

        //3) Bir Menu gəlməlidi və menu-da aşağıdakı əməliyyatlar olmalıdı:

        //        1. Show all students
        //        2. Get student by id
        //        3. Add student
        //        0. Quit
        //Əgər console-dan 1 göndərilsə ekrana bütün student-lərin məlumatları çıxamlıdı,
        //2 göndərilsə console-dan bir id istənməlidir və həmin id-li Student obyekti tapılıb onun bütün məlumatları console-a yazdırılmalıdır,
        //3 göndərilsə console-dan Student-in bütün məlumatları istənib yeni bir Student yaranmalıdır, 0 göndərilərsə program sonlanmalıdır


        #endregion


        Student student = new Student(1, "bastijamal", 100);

        student.StudentInfo();

        Console.WriteLine("====================");






        List<Student> students = new List<Student>(); // Internetden baxdim errorumu helle eledi

        string choice;
        do
        {
            Console.WriteLine(":)  XOSH GELMISOOOZZZZ :) ");
            Console.WriteLine("Yeni istifadechi uchun melumatlari daxil edin");

            Console.WriteLine("istifadechi fullname: ");
            string fullname = Console.ReadLine();

            Console.Write("ID daxil edin: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Point daxil edin: ");
            double point = Convert.ToInt32(Console.ReadLine());

            Student newStudent = new Student(id, fullname, point);
            Console.WriteLine("yeni student yaradildi");

            Console.WriteLine("Section Menu");
            Console.WriteLine("1. Show info \n 2. Create new group");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Show Info");
                    newStudent.StudentInfo(); 
                    break;

                case "2":
                    Console.WriteLine("Yeni grup melumatlari daxil edin:");

                    Console.Write("Grup No:  ");
                    string groupNo = Console.ReadLine();

                    Console.Write("Student limiti:  ");
                    int studentlimit = Convert.ToInt32(Console.ReadLine());

                    Group group = new Group(studentlimit, groupNo);
                    Console.WriteLine("\nYeni Grup yaradildi:");

       
                    do
                    {
                        Console.WriteLine("Menu:");
                        Console.WriteLine("1. Show all students");
                        Console.WriteLine("2. Get student by id");
                        Console.WriteLine("3. Add student");
                        Console.WriteLine("0. Quit");

                        choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "1":
                                Console.WriteLine("All Students:");
                                foreach (var a in students)
                                {
                                    a.StudentInfo();
                                }
                                break;

                            case "2":
                                Console.Write("Enter student ID: ");
                                int studentId = Convert.ToInt32(Console.ReadLine());
                                //davamin nese tutdurammadim
                                break;

                            case "3":
                                Console.WriteLine("Enter new student information:");
                                Console.Write("ID: ");
                                int newId = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Fullname: ");
                                string newFullname = Console.ReadLine();
                                Console.Write("Point: ");
                                double newPoint = Convert.ToDouble(Console.ReadLine());

                                students.Add(new Student(newId, newFullname, newPoint));
                                Console.WriteLine("Yeni student elave olundu.");
                                break;

                            case "0":
                                Console.WriteLine("Programdan chixishh...");
                                break;

                            default:
                                Console.WriteLine("Sehv sechimmm");
                                break;
                        }
                    } while (choice != "0");
                    break;

                default:
                    Console.WriteLine("Duzgun olmayan sechim seçim.");
                    break;
            }
        } while (choice != "0");
    }
}
