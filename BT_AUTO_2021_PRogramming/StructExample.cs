using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
   public class StructExample
    {
        struct MyStruct
        {
            int number;
            string testString;

            public void Assign(int number, string testString);
        {
            this.number = number;
            this.testString = testString;
            }

    }
    public int ComputeSum()
    {
        int sum = 0
            {
            for (int i = 0; i < number; i++)
            {
                sum += i;
            }
            return sum;
        }
    }

    public struct Rectangle3d
    {
        double l;
        double L;
        double h;

        public void Assign(double l, double L, double h)
        {
            this.l = l;
            this.L = L;
            this.h = h;
        }
        public int GetVertices()
        {
            return 12;
        }
        public double GetArea()
        {
            return 4 * L;
        }
        public double GetVolume()
        {
            return 12 * l;
        }

    }
}
