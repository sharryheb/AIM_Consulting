using System;

namespace LinkedList
{
    class Node
    {
        public Node next { set; get; }
        public int data { set; get; }
    }

    class LList
    {
        public Node header { set; get; }

        public void Add(int input)
        {
            if (header == null)
            {
                header = new Node();
                header.data = input;
            }

            else
            {
                Node tmp = new Node();
                tmp.data = input;
                tmp.next = header;
                header = tmp;
            }
        }

        public void Reverse()
        {
            Node current = header;
            while (current != null && current.next != null)
            {
                Node Tmp = current.next.next;
                current.next.next = header;
                header = current.next;
                current.next = Tmp;
            }
        }

        public void ReadList()
        {
            Node current = header;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
