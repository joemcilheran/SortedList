using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListProject
{
    class SystemArrayString: ICustomString
    {
        char[] characterArray;
        public SystemArrayString(string incomingString)
        {
            characterArray = incomingString.ToArray();
        }
        public override string ToString()
        {
            string arrayString = new string(characterArray);
            return arrayString;
        }

        public void Insert(int startIndex, string stringToInsert)
        {
            char[] insertionArray = stringToInsert.ToArray();
            int largeArrayLength = (insertionArray.Length + characterArray.Length);
            char[] largeArray = new char[largeArrayLength];
            int characterIndex;
            foreach (char character in characterArray)
            {
                characterIndex = Array.IndexOf(characterArray, character);
                if (characterIndex < startIndex)
                {
                    largeArray[characterIndex] = character;
                }
                else
                {
                    largeArray[characterIndex + insertionArray.Length] = character;
                }
            }
            foreach(char character in insertionArray)
            {
                characterIndex = Array.IndexOf(insertionArray, character);
                largeArray[startIndex + characterIndex] = character;
            }
            characterArray = largeArray;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            int characterArrayLength = Length();
            int newArrayLength = (characterArrayLength - numCharsToRemove);
            char[] newArray = new char[newArrayLength];
            for(int i = 0;  i < characterArrayLength; i++)
            {
                if (i < startIndex)
                {
                    newArray[i] = characterArray[i];
                }
                else if(i >= (startIndex + numCharsToRemove))
                {
                    newArray[i- numCharsToRemove] = characterArray[i];
                }

            }
            characterArray = newArray;
        }

        public int Length()
        {
            int length = characterArray.Length;
            return length;
        }
    }
}
