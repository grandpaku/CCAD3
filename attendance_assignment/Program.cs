using System;
using System.Collections.Generic;

namespace Attendance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ATTENDANCE WILL BE TAKEN FOR THOSE STUDENTS WHO WILL LAY DOWN THEIR LIVES IN THE NAME OF PROGRESS\n");
            Dictionary<string, string> studentDict = new Dictionary<string, string>();
            List<string> studentNames = new List<string>();
            studentNames.Add("Kristen");
            studentNames.Add("Issaiah");
            studentNames.Add("Leon");
            studentNames.Add("Lucy");
            studentNames.Add("Michael");
            studentNames.Add("Emily");
            List<string> teacherSayings = new List<string>();
            teacherSayings.Add("DISHONOR!!! DISHONOR ON YOU, DISHONOR ON YOUR COW!!");
            teacherSayings.Add("DISHONOR!!! DISHONOR ON YOU, DISHONOR ON YOUR COW!!");
            teacherSayings.Add("That tracks. They've always been a coward");
            teacherSayings.Add("Imagine being a disgrace.... ");
            teacherSayings.Add("Must be nice, it must be niiiice, to have no one on your side");
            teacherSayings.Add("I guess they're not throwing away their shot");
            teacherSayings.Add("IIIIII- don't have the energy. Good for them.");

            foreach (string student in studentNames)
            {
                studentDict.Add(student, "A+");
                Console.WriteLine($"Is {student} here? (y/n)");
                string option = Console.ReadLine();
                option = option.ToLower();
                if (option == "y")
                {
                    Console.WriteLine($"Thank you for being here {student}, you have brought your family honor.");
                }
                else if (option == "n")
                {
                    grade(student);
                    disgrace();
                }
            }
            Console.WriteLine("This concludes class attendance, press any key to end it");
            Console.ReadKey();


            void disgrace()
            {
                teacherSayings.RemoveAt(0);
                foreach (string saying in teacherSayings)
                {
                    Console.WriteLine(saying);
                    break;
                }
            }

            void grade(string studentC)
            {
                string x = studentC;
                studentDict[x] = "0";
            }












            //List<char> charNames = new List<char>();

        //else if (option == "f")
        //{
        //    secrets();
        //    break;
        //}


        //void secrets()
        //{
        //    foreach (string student in studentNames)
        //    {
        //        char secret = student[0];
        //        secret.ToString();
        //        string secretCode = "You've unlocked the secret phrase: ";
        //        secretCode += secret;
        //        Console.WriteLine(secretCode);
        //    }
        //}
    }

    }
}
