using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AITLibrary
{
    public class PresentationLayerException :Exception
    {
        const string generalMessage =
           "General Form Exception:\n";

        public PresentationLayerException()
        : base(generalMessage)
        {
            System.Windows.Forms.MessageBox.Show(generalMessage);
        }

        public PresentationLayerException(string aMessage)
        : base(String.Format("{0} - {1}",
                generalMessage, aMessage))
        {
            System.Windows.Forms.MessageBox.Show(generalMessage + aMessage, "Presentation Layer Exception");
        }

        public PresentationLayerException(string aMessage, Exception inner)
        : base(aMessage, inner)
        {
            System.Windows.Forms.MessageBox.Show(aMessage, inner.ToString());
        }
    }
}
