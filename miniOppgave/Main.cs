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
                new Student(1, "Lars Larsen", "I'm Me", FagList),
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

        }

        public void PrintAllSubjects()
        {
            foreach (var fag in FagList)
            {
                Console.WriteLine(fag.Name);
                Console.WriteLine(fag.Description);
                Console.WriteLine(fag.Value);
            }
        }

        public void PrintAllStudents()
        {
            foreach (var student in StudentList)
            {
                Console.WriteLine(student.Name);
                Console.WriteLine(student.Description);
               PrintAllSubjects();
            }
        }
    }


}

