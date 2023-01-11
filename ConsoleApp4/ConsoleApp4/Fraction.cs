using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Fraction
    {
        private int numera;
        private int denomina;

        public int Numerator
        {
            set { numera = value; }
            get { return numera; }
        }
        public int Denominator
        {
            get { return denomina == 0 ? 1 : denomina; }
            set
            {
                if (value == 0)
                    throw new InvalidOperationException("Denominator cannot be assigned a 0 Value.");
                denomina = value;
            }
        }

        public Fraction()
        {
        }
        public Fraction(int numerator, int denominator)
        {
            int GCD = this.GCD(numerator, denominator);
            Numerator = numerator / GCD;
            Denominator = denominator / GCD;
        }
        public int GCD(int x, int y)
        {
            if (y == 0) return x;
            else return GCD(y, x % y);
        }
        public void Print()
        {
            Console.WriteLine($"{Numerator}/{Denominator}");
        }

        public void Add(Fraction f, Fraction s)
        {
            int num = f.Numerator * s.Denominator + s.Numerator * f.Denominator;
            int den = f.Denominator * s.Denominator;
            Fraction result = new Fraction(num, den);
            result.Print();
        }
        public void Subtract(Fraction f, Fraction s)
        {
            int num = f.Numerator * s.Denominator - s.Numerator * f.Denominator;
            int den = f.Denominator * s.Denominator;
            Fraction result = new Fraction(num, den);
            result.Print();
        }
        public void Multiply(Fraction f, Fraction s)
        {
            int num = f.Numerator * s.Numerator;
            int den = f.Denominator * s.Denominator;
            Fraction result = new Fraction(num, den);
            result.Print();
        }
        public void Divide(Fraction f, Fraction s)
        {
            int num = f.Numerator * s.Denominator;
            int den = f.Denominator * s.Numerator;
            Fraction result = new Fraction(num, den);
            result.Print();
        }
        public void Decimal(Fraction f, Fraction s)
        {
            double Decimal = (double)numera / denomina;
            Console.WriteLine(Decimal);
        }
    }
}

