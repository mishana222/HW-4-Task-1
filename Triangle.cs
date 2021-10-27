using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_Task_1
{
    public class Triangle
    {
        protected double first;
        protected double second;
        protected double third;

        protected Triangle() { }

        public Triangle(double first_side, double second_side, double third_side)
        {
            if (first_side > 0 && second_side > 0 && third_side > 0
                && first_side + second_side > third_side
                && second_side + third_side > first_side
                && first_side + third_side > second_side)
            {
                first = first_side;
                second = second_side;
                third = third_side;
            }
            else
                throw new Exception();
        }

        public bool ChangeSides(double first_side, double second_side, double third_side)
        {
            if (first_side > 0 && second_side > 0 && third_side > 0
                && first_side + second_side > third_side
                && second_side + third_side > first_side
                && first_side + third_side > second_side)
            {
                first = first_side;
                second = second_side;
                third = third_side;

                return true;
            }
            return false;
        }

        public double GetPerimetr()
        {
            return first + second + third;
        }

        public double GetAlpha()
        {
            double cosAlpha = (Math.Pow(second, 2) + Math.Pow(third, 2) - Math.Pow(first, 2)) / (2 * second * third);
            return (Math.Acos(cosAlpha) / (Math.PI) ) * 180;
        }

        public double GetBetta()
        {
            double cosBetta = (Math.Pow(first, 2) + Math.Pow(third, 2) - Math.Pow(second, 2)) / (2 * first * third);
            return (Math.Acos(cosBetta) / (Math.PI)) * 180;
        }
        public double GetGamma()
        {
            double cosGamma = (Math.Pow(first, 2) + Math.Pow(second, 2) - Math.Pow(third, 2)) / (2 * first * second);
            return (Math.Acos(cosGamma) / (Math.PI) ) * 180;
        }
    }

    public class EquilTriangle : Triangle
    {
        public EquilTriangle(double first_side, double second_side, double third_side)
        {
            if (first_side > 0
                && first_side == second_side
                && second_side == third_side)
            {
                first = first_side;
                second = second_side;
                third = third_side;
            }
            else
                throw new Exception();
        }

        public double GetArea()
        {
            return (Math.Pow(first, 2) * Math.Sqrt(3)) / 4;
        }
    }
}
