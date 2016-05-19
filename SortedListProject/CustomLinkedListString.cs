using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListProject
{
    class CustomLinkedListString : ICustomString
    {
        public Node head;
        public Node tail;
        public Node currentNode;
        public int size;
        public class Node
        {
            public char value;
            public Node Next;
        }
        public CustomLinkedListString(string String)
        {

            head = null;
            currentNode = null;
            Node newNode = null;
            for (int i = 0; i < String.Length; i++)
            {
                if (head == null)
                {
                    head = new Node();
                    head.value = String[i];
                    size++;
                }
                else if (head.Next == null)
                {
                    currentNode = new Node();
                    currentNode.value = String[i];
                    head.Next = currentNode;
                    size++;
                }
                else
                {
                    newNode = new Node();
                    newNode.value = String[i];
                    currentNode.Next = newNode;//works, but node.Next always appears null.
                    currentNode = newNode;
                    size++;
                }
                tail = currentNode;

            }
        }
        public override string ToString()
        {
            List<string> newList = new List<string>(size);
            Node node = head;
            while (node != null)
            {
                string value = Convert.ToString(node.value);
                newList.Add(value);
                node = node.Next;
            }
            string output = string.Join("", newList.ToArray());
            return output;
        }

        public void Insert(int startIndex, string stringToInsert)
        {
            int counter = 0;
            Node node = head;
            Node lastNodeBeforeInsertion = null;
            while (counter < (startIndex - 1))
            {
                node = node.Next;
                lastNodeBeforeInsertion = node;
                counter++;
            }
            CustomLinkedListString insertionLinkedList = new CustomLinkedListString(stringToInsert);
            size = size + insertionLinkedList.size;
            Node firstNodeOfSecondHalf = lastNodeBeforeInsertion.Next;
            Node lastNodeOfInsertion = insertionLinkedList.tail;
            Node firstNodeOfInsertion = insertionLinkedList.head;
            lastNodeOfInsertion.Next = firstNodeOfSecondHalf;
            lastNodeBeforeInsertion.Next = firstNodeOfInsertion;


        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            int counter = 0;
            Node node = head;
            Node lastNodeBeforeRemoval = head;
            while (counter < (startIndex - 1))
            {
                node = node.Next;
                lastNodeBeforeRemoval = node;
                counter++;
            }
            counter = 0;
            node = lastNodeBeforeRemoval.Next;
            Node lastNodeOfRemoval = null;
            while (counter < (numCharsToRemove - 1))
            {
                node = node.Next;
                lastNodeOfRemoval = node;
                counter++;
            }
            lastNodeBeforeRemoval.Next = lastNodeOfRemoval.Next;
            size = size - numCharsToRemove;


        }

        public int Length()
        {
            int length = size;
            return length;
        }
    }
}
