using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workingWithClasses
{
    public class Subject
    {
        public Subject() { }
        public Subject(string subjectName, bool attestation, int grade)
        {
            SubjectName = subjectName;
            Attestation = attestation;
            Grade = grade;
        }
        public string SubjectName { get; set; }
        public bool Attestation { get; set; }
        public int Grade { get; set; }

        public override string ToString()
        {
            return "Предмет: " + SubjectName + " |Аттестация: " + Attestation + " |Оценка♥: " + Grade;
        }
    }
}