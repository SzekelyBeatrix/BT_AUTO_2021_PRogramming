using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
    class BtException : Exception
    {
        string myCustomMessage;
        public BtException(string message)
        {
            this.myCustomMessage = "BT EXCEPTION: " + message;
        }
        public override string ToString()
        {
            return myCustomMessage + base.ToString();
        }
        
        
    }
}
