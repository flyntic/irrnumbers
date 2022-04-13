using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Fraction
    {
        public int Numerator { get; set; }
        public int Denomerator { get; set; }
        public bool Negative { get; set; }

        public Fraction (int n, int d)
        {
            Negative =((n*d)<0);
            Numerator = ((n<0)?-1:1)*n;
            Denomerator = ((d < 0) ? -1 : 1) * d ;
        }

        public static bool operator true(Fraction f)
        {
            return (f.Denomerator>f.Numerator);
        }
        public static bool operator false(Fraction f)
        {
            return (f.Denomerator <= f.Numerator);
        }
        public override string ToString()
        {
            Socr();
            return ($"{Numerator}{((Denomerator!=1)?$"/{Denomerator}":"")}");
        }
        public static bool Equals(Fraction c1, Fraction c2)
        {
            return ((c1.Numerator * c2.Denomerator) == (c1.Denomerator * c2.Numerator)); 
        }
        public static Fraction operator +(Fraction c1, Fraction c2)
        {
            return new Fraction(  c1.Numerator*c2.Denomerator + c2.Numerator*c1.Denomerator, c1.Denomerator* c2.Denomerator );
        }
        public static Fraction operator -(Fraction c1, Fraction c2)
        {
            return new Fraction(c1.Numerator * c2.Denomerator - c2.Numerator * c1.Denomerator, c1.Denomerator * c2.Denomerator);
        }
        public static Fraction operator *(Fraction c1, Fraction c2)
        {
            return new Fraction(c1.Numerator  * c2.Numerator, c1.Denomerator * c2.Denomerator);
        }

        public static implicit operator Fraction(int A)
        {
            return new Fraction(A,1);
        }

        public static Fraction operator /(Fraction c1, Fraction c2)
        {
            return new Fraction(c1.Numerator * c2.Denomerator, c1.Denomerator * c2.Numerator);
        }

        public Fraction Socr()
        {
            int d=2;

            do
            {
                if (((Numerator % d)==0) && ((Denomerator % d)==0))
                {
                    Numerator = Numerator / d;
                    Denomerator =Denomerator / d;
                }
                else d++;

            } while ((d <= Numerator) && (d <= Denomerator));

            return this;
        }
    }
}
