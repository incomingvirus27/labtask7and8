using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPortal
{
    class ScienceStudent:Student
    {
        private double elecCir;
        private double circuitAna;
        private double analogComm;

        public ScienceStudent(int regNo, string name, double scores, double elecCir, double circuitAna, double analogComm) : base(regNo, name, scores)
        {
            Elec = elecCir;
            Circuit = circuitAna;
            Analog = analogComm;
        }
        public double Elec
        {
            get { return elecCir; }
            set { elecCir = value; }
        }
        public double Circuit
        {
            get { return Circuit; }
            set { Circuit = value; }
        }
        public double Analog
        {
            get { return analogComm; }
            set { analogComm = value; }
        }

        public override double Average(double Analog, double Circuit, double Elec)
        {
            return (Analog + Circuit + Elec) / 3;
        }
    }
}
