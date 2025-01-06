using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Classses
{
    internal class Student
    {
        #region properities
        public int Id { get; set; }
        public string Name { get; set; }
        public double Degree { get; set; }

        #endregion

        #region constructors
        public Student(int id , string name , double deg)
        {
            Id = id;
            Name = name;
            Degree = deg;
        }
        public Student(Student student)
        {
            Id = student.Id;
            Name = student.Name;
            Degree = student.Degree;
        }

        #endregion

        #region Method
        public override string ToString()
        {
            return $"ID = {Id} , Name = {Name} , Degree = {Degree}";
        }
        #endregion
    }
}
