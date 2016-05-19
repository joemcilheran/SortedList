using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemString systemString = new SystemString("alpha");
            SystemArrayString systemArrayString = new SystemArrayString("beta");
            SystemLinkedListString systemLinkedListString = new SystemLinkedListString("lambda");
            CustomLinkedListString customLinkedString = new CustomLinkedListString("psy");
            SortedList<int, ICustomString> sortedStringList = new SortedList<int, ICustomString>();
            sortedStringList.Add(systemString.Length(), systemString);
            sortedStringList.Add(systemArrayString.Length(), systemArrayString);
            sortedStringList.Add(systemLinkedListString.Length(), systemLinkedListString);
            sortedStringList.Add(customLinkedString.Length(), customLinkedString);
            Console.ReadKey();
        }
    }
}
