using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace miniOppgave
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Fag> Fag { get; set; }
        public Student(int id, string name, string description, List<Fag> fag)
        {
            Id = id;
            Name = name;
            Description = description;
            Fag = fag;
        }

        public void printSubjects()
        {
            
            foreach (var fag in Fag)
            {
                
                    Console.WriteLine(fag.Name);
                    Console.WriteLine(fag.Description);
                    Console.WriteLine(fag.Value);
                
            }

        }

        private void JoinSubject()
        {
            
        }
    }
}
