using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EnvelopeTaskLibrary
{
   public  class DefaultSettings
    {
        public const int SIDES_COUNT = 2;
        public const string QUESTION = "Do you want to continue?";
        public const string MESSAGE = "Press any key";
        public const string RIGHT_ENVELOPE = "It is possible to insert the envelope";
        public const string INSTRUCTION = "Please input <height> of evelope and " +
                "<width> of envelope\nBetween these parameters use separator <,>\n" +
                "After these actions you get answer\n" +
                "If you want to continue check envelopes,\n" +
                "You should input <y> or <yes>\n" +
                "And then <Enter> register doesn't metter\n" +
                "If you don't want to continue input any key";
        
    }
}
