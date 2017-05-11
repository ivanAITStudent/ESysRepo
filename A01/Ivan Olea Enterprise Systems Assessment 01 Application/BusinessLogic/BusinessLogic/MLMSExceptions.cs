using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class MLMSExceptions : Exception
    {
        const string generalMessage =
            "Exception: General MLMS Exception";

        public MLMSExceptions()
        : base(generalMessage)
        {

        }

        public MLMSExceptions(string aMessage)
        : base(String.Format("{0} - {1}",
                generalMessage, aMessage))
        {

        }

        public MLMSExceptions(string aMessage, Exception inner)
        : base(aMessage, inner)
        {

        }
    }
}
