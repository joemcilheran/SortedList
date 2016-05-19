using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListProject
{
    class SystemLinkedListString : ICustomString
    {
        LinkedList<char> characterLinkedList;
        char[] characterArray;
        public SystemLinkedListString(string String)
        {
            characterArray = String.ToCharArray();
            characterLinkedList = new LinkedList<char>(characterArray);
        }
        public override string ToString()
        {
            char[] newArray = new char[Length()];
            characterLinkedList.CopyTo(newArray, 0);
            string characterLinkedListString = new string(newArray);
            return characterLinkedListString;
        }

        public void Insert(int startIndex, string stringToInsert)
        {
            int counter = 0;
            LinkedListNode<char> elementNode = null;
            for (LinkedListNode<char> node = characterLinkedList.First; counter < startIndex; node = node.Next)
            {
                elementNode = node;
                counter++;
            }
            for (int i = 0; i < stringToInsert.Length; i++)
            {
                LinkedListNode<char> newNode = new LinkedListNode<char>(stringToInsert[i]);
                characterLinkedList.AddAfter(elementNode, newNode);
                elementNode = newNode;
            }

        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            int counter = 0;
            LinkedListNode<char> elementNode = null;
            for (LinkedListNode<char> node = characterLinkedList.First; counter < startIndex; node = node.Next)
            {
                elementNode = node;
                counter++;
            }
            int secondCounter = 0;
            for (LinkedListNode<char> thisNode = elementNode.Next; secondCounter < numCharsToRemove; thisNode = elementNode.Next)
            {
                characterLinkedList.Remove(thisNode);
                secondCounter++;
            }

        }

        public int Length()
        {
            int length = characterLinkedList.Count;
            return length;
        }
    }
}
