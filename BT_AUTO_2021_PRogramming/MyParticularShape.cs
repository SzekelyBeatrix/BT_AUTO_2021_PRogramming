using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
    class MyParticularShape : AbstractShape, IClass , IIntf
    {
        public override void Color()
        {
            throw new NotImplementedException();
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        void IClass.Print()
        {
            Console.WriteLine("Printing the shape!");
        }

        void IIntf.Print()
        {
            Console.WriteLine("Printing the shape interface!");
        }
    }
}
