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

        private bool run = true;
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
                new Student(1, "Kim Larsen", "I'm Me", new List<Fag> { FagList[1], }),
                new Student(1, "Blake Larsen", "I'm Me", new List<Fag> {FagList[0], FagList[2] })
            };


        }
        public void MainMenu()
            {
                while (run)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("What do you need to check?");
                    Console.WriteLine("1. Student report card");
                    Console.WriteLine("2. Subject overview");
                    Console.WriteLine("3. Student overview");
                    Console.WriteLine("4. Exit");
                    var input = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
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
                        case "4":
                            run = false;
                            break;
                    }
                }
            }
        public void PrintStudent()
        {
            for (int i = 0; i < StudentList.Count; i++)
            {
                Console.WriteLine($"ID: {i + 1} Name:  {StudentList[i].Name}");
            }
            int userInput = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(StudentList[userInput - 1].Name);
                Console.WriteLine(StudentList[userInput - 1].Description);
                StudentList[userInput - 1].printSubjects();
                Console.ReadKey();
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
            Console.ReadKey();
        }

        
    }


}

