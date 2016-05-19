using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListProject
{
    interface ICustomString
    {
        string ToString();

        void Insert(int startIndex, string stringToInsert);

        void Remove(int startIndex, int numCharsToRemove);

        int Length();

    }
}
