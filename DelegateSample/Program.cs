using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{
    class Polytech
    {
        public double gpa;
        public Polytech(double gpa)
        {
            this.gpa = gpa;
        }
        public void Graduate()
        {
            Console.WriteLine("Still studied in Polytech!");
        }

        internal void NGraduate()
        {
            throw new NotImplementedException();
        }
    }

    delegate void Graduation();

    class University
    {
        public void Graduate(Graduation graduation)
        {
            graduation.Invoke();
        }
    }

    class KBTU
    {
       public double gpa;
        public KBTU(double gpa)
        {
            this.gpa = gpa;
        }
        public void Graduate()
        {
            Console.WriteLine("Studied from KBTU!");
        }

        public void NGraduate()
        {
            Console.WriteLine("Still studied in KBTU!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            KBTU k = new KBTU(3.2);
            Polytech p = new Polytech(3.2);
            University u = new University();

            Graduation g = null;

            if (s == "k")
            {
                if (k.gpa > 3.5)
                {
                    g = k.Graduate;
                }
                else
                {
                    g = k.NGraduate;
                }
            }
            else
            {
                if (k.gpa > 3.0)
                {
                    g = p.Graduate;
                }
                else
                {
                    g = p.NGraduate;
                }
            }

            u.Graduate(g);
        }
    }
}
