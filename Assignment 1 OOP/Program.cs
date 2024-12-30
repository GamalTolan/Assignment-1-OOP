using Assignment_1_OOP.Data_Types;
using Assignment_1_OOP.Enum;

using System;

namespace Assignment_1_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Try all what we have learned in the lecture.(part 01)


            #region Ex01
            //Person person = new Person();   
            //person.Id = 1;
            //person.Name= "Ahmed";
            //person.gender=Gender.Male;
            //Console.WriteLine(person.gender);


            //Grade grade =  Grade.A;
            //if (grade == Grade.A)
            //    Console.WriteLine("Excellent");
            //else
            //    Console.WriteLine("good luck");

            //grade = (Grade)5;
            //Console.WriteLine(grade);

            //Grade grade2=new Grade();
            //Console.WriteLine(grade2);
            #endregion

            #region Ex02

            // Student student = new Student();
            // bool isParsed;
            // Console.WriteLine("Enter Student Data :");
            // Console.WriteLine("Id:");
            // int Id;
            // do
            // {
            //     isParsed = int.TryParse(Console.ReadLine(), out Id);
            //     if (!isParsed)
            //         Console.WriteLine("Invalid Variable");
            // } while (!isParsed);
            // student.Id = Id;

            // Console.WriteLine("Name :");
            //student.Name = Console.ReadLine();

            // Console.WriteLine("Gender :");
            // object gender;
            // do
            // {
            //     isParsed = Enum.Gender.TryParse(typeof(Gender),Console.ReadLine(), true, out gender);
            //     if (!isParsed)
            //         Console.WriteLine("Invalid Variable");
            // } while (!isParsed);
            // student.Gender = (Gender)gender;

            // Console.WriteLine("Grade :");
            // object grade;
            // do
            // {
            //     isParsed = Enum.Grade.TryParse(typeof(Grade), Console.ReadLine(),true,out grade);
            //     if (!isParsed)
            //         Console.WriteLine("Invalid Variable");
            // } while (!isParsed);
            // student.Grade = (Grade)grade;

            // Console.WriteLine("Branch :");
            // object branch;
            // do
            // {
            //     isParsed = Enum.Branch.TryParse(typeof(Branch), Console.ReadLine(), true, out branch);
            //     if (!isParsed)
            //         Console.WriteLine("Invalid Variable");
            // } while (!isParsed);
            // student.Branch = (Branch)branch;


            // Console.WriteLine($"Student id = {student.Id} , Name : {student.Name} , Student Gender :{student.Gender}, Student Grade : {student.Grade} , Branch {student.Branch}");


            #endregion

            #region Ex03
            //User user = new User();
            //user.Id = 1;
            //user.Permissions = (Permission)2;
            ////Console.WriteLine(user.Permissions);
            //user.Permissions = user.Permissions ^ Permission.Read;
            //Console.WriteLine(user.Permissions);

            #endregion

            #endregion

            #region Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

            //string[] Weekdayes = Enum.WeekDays.GetNames(typeof(WeekDays));

            //foreach (string Weekday in Weekdayes) 
            //Console.WriteLine(Weekday);


            #endregion

            #region Create an enum called "Season"

            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            //string input = Console.ReadLine();

            //if (Enum.Season.TryParse( input, true, out Season season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid input");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("try Again");
            //}

            #endregion

            #region   Assign the following Permissions (Read, write, Delete, Execute)

            //User user = new User();
            //user.Id = 1;
            //user.Permissions = (Permission)2;
            //Console.WriteLine(user.Permissions);

            //user.Permissions = user.Permissions |Permission.Read;
            //Console.WriteLine(user.Permissions);

            //user.Permissions = user.Permissions & Permission.Write;
            //Console.WriteLine(user.Permissions);

            #endregion


            #region Create an enum called "Colors" with the basic colors (Red, Green, Blue) 

            bool isParsed;
            Colors color;
            do
            {
                Console.WriteLine("Enter a color : ");
                string inputcolor = Console.ReadLine();
                isParsed = Enum.Colors.TryParse(inputcolor, true, out color);

                if (isParsed)
                    Console.WriteLine("is a primary color");
                else
                    Console.WriteLine("Not primary color ");

            } while (!isParsed);

            
        }
        #endregion

    }
    
}
