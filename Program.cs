using System;

namespace CodeSnippets
{
    public class CodeSnippets
    {
        private static int BinarySearch(int[] data, int left, int right, int searchElem)
        {
            if (right >= left) {
                int mid = left + (right - left) / 2;

                if (data[mid] == searchElem)
                    return mid;

                if (data[mid] > searchElem)
                    return BinarySearch(data, left, mid - 1, searchElem);

                return BinarySearch(data, mid + 1, right, searchElem);
            }
            return -1;
        }

        static void Main()
	    {
            Console.WriteLine("/******************** BINARY SEARCH **********************/");
            int[] data = { 2, 3, 4, 10, 40 };
            int searchElem = 4;

            int result = BinarySearch(data, 0, data.Length - 1, searchElem);

            Console.WriteLine("Searching for " + searchElem + " in array: ");
            foreach(int elem in data)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();

            if (result < 0)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index " + result);

            Console.WriteLine();


            Console.WriteLine("/******************** BINARY TREE DEPTH **********************/");
            BinaryTree.Tree tree = new BinaryTree.Tree();
            tree.Insert(50);
            tree.Insert(17);
            tree.Insert(23);
            tree.Insert(12);
            tree.Insert(19);
            tree.Insert(54);
            tree.Insert(9);
            tree.Insert(14);
            tree.Insert(67);
            tree.Insert(76);
            tree.Insert(72);

            int depth = tree.Depth();

            Console.WriteLine("Tree Root Node is " + tree.TreeRoot.data);
            Console.WriteLine("Tree Depth is " + depth);
            Console.WriteLine();


            Console.WriteLine("/******************** REVERSE LINKED LIST **********************/");
            LinkedList.LList lList = new LinkedList.LList();
            for (int i = 10; i >= 1; i--)
            {
                lList.Add(i);
            }

            Console.WriteLine("Original order linked list: ");
            lList.ReadList();

            lList.Reverse();

            Console.WriteLine("Reverse order linked list: ");
            lList.ReadList();
	    }
    }
}
