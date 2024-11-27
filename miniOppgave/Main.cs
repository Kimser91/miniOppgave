using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace miniOppgave
{
    internal class Main
    {
        public List<Fag> FagList { set; get; }
        public List<Student> StudentList { set; get; }
        public List<Karakter> Grades { set; get; }

        public Main()
        {
            FagList = new List<Fag>()
            {
                new Fag("Math", "Math for Dummies 101", 10),
                new Fag("English", "Introduction To Conversational English", 30),
                new Fag("Geografic", "Find your way home", 15)
            };
            StudentList = new List<Student>()
            {
                new Student(1, "Lars Larsen", "I'm Me", new List<Fag> {FagList[0], FagList[1], FagList[2] }),
            };


        }
        public void MainMenu()
            {
                Console.WriteLine("What do you need to check?");
                Console.WriteLine("1. Student report card");
                Console.WriteLine("2. Subject overview");
                Console.WriteLine("3. Student overview");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":

                        PrintStudent();
                        break;
                    case "2":
                        PrintAllSubjects();
                        break;
                    case "3":
                        PrintAllStudents();
                        break;
                }
            }
        public void PrintStudent()
        {
            var userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.WriteLine(StudentList[0].Name);
                Console.WriteLine(StudentList[0].Description);
                StudentList[0].printSubjects();
            }

        }

        public void PrintAllSubjects()
        {
            int id = 0;
            foreach (var fag in FagList)
            {
                Console.WriteLine("Subject ID: "+id);
                Console.WriteLine(fag.Name);
                Console.WriteLine(fag.Description);
                Console.WriteLine(fag.Value);
                id++;
            }
        }

        public void PrintAllStudents()
        {
            foreach (var student in StudentList)
            {
                Console.WriteLine(student.Name);
                Console.WriteLine(student.Description);
               
            }
        }

        
    }


}

