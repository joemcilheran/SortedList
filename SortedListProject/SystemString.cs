using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListProject
{
    class SystemString : ICustomString
    {
        String verySpecialstring;
        public SystemString(string incomingString)
        {
            verySpecialstring = incomingString;
        }
        public override string ToString()
        {
            return verySpecialstring;
        }

        public void Insert(int startIndex, string stringToInsert)
        {
            verySpecialstring.Insert(startIndex, stringToInsert);
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            verySpecialstring.Remove(startIndex, numCharsToRemove);
        }

        public int Length()
        {
            int length = verySpecialstring.Length;
            return length;
        }

    }
}
