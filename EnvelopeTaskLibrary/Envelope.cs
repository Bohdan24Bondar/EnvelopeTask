using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopeTaskLibrary
{
    public class Envelope : IComparable<Envelope>
    {
        public Envelope(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public Envelope(Envelope currentEnvelope)
        {
            Height = currentEnvelope.Height;
            Width = currentEnvelope.Width;
        }

        public double Height { get; private set; }


        public double Width { get; private set; }

        public int CompareTo(Envelope other)
        {
            int result = 0;

            if ((Height > other.Height) && (Width > other.Width)
                    || (Height > other.Width) && (Width > other.Height))
            {
                result = 1;
            }
            else
            {
                if ((Height < other.Height) && (Width < other.Width)
                        || (Height < other.Width) && (Width < other.Height))
                {
                    result = -1;
                }
            }

            return result;
        }

        public override string ToString()
        {
            return string.Format("Envelope:\nHeight = {0}\nWidth = {1}", Height, Width);
        }
    }
}
