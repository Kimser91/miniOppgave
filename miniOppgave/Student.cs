using System;
using System.Collections.Generic;
using System.Linq;
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


    }
}
