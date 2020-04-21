using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPortal
{
    class CommerceStudent:Student
    {
        private double comNet;
        private double dataStruc;
        private double cSharp;

        public CommerceStudent(int regNo, string name, double scores, double comNet, double dataStruc, double cSharp) : base(regNo, name, scores)
        {
            ComNet = comNet;
            DataStruc = dataStruc;
            Csharp = cSharp;
        }
        public double ComNet
        {
            get { return comNet; }
            set { comNet = value; }
        }
        public double DataStruc
        {
            get { return dataStruc; }
            set { dataStruc = value; }
        }
        public double Csharp
        {
            get { return cSharp; }
            set { cSharp = value; }
        }

        public override double Average(double comNet, double dataStruc, double csharp)
        {
            return (comNet + dataStruc + csharp) / 3;
        }
    }
}
