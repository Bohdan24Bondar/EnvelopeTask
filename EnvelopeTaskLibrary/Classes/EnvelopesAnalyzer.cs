using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopeTaskLibrary
{
    public class EnvelopesAnalyzer
    {
        public bool CanPutInEnvelope(Envelope bigEnvelope, Envelope smallEnvelope)
        {
            bool canPutIn = false;
            int result = bigEnvelope.CompareTo(smallEnvelope);

            if (result == 1)
            {
                canPutIn = true;
            }

            return canPutIn;
        }
    }
}
