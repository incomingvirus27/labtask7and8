using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPortal
{
    class Student
    {
        public int regNo;
        public string name;
        public double scores;

        public Student(int regNo, string name, double scores)
        {
            RegNo = regNo;
            Name = name;
            Scores = scores;
        }
        public int RegNo
        {
            get { return regNo}
            set { regNo = value}
        }
        public string Name
        {
            get { return name}
            set { name = value}
        }
        public double Scores
        {
            get { return scores}
            set { scores = value}
        }
        public virtual double Average(double num1, double num2, double num3)
        {
            return (num1 + num2 + num3) / 3;
        }
        public override string ToString()
        {
            return $"student name {Name} with {RegNo} and with scores {Scores} have an average of {}"; 
        }

    }
}
