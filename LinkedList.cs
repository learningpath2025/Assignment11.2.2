using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11._2._2
{
    public class LinkedList
    {
        public Node reverse_list(Node head)
        {
            // Edge case: empty list or list with only one node
            if (head == null || head.next == null)
            {
                return head;
            }

            // Initialize pointers
            Node prev = null;
            Node current = head;

            while (current != null)
            {
                // Store next node
                Node next = current.next;
                // Reverse current node's pointer
                current.next = prev;
                // Update pointers
                prev = current;
                current = next;
            }

            return prev;
        }
    }
}
