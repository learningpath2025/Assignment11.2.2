namespace Assignment11._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create linked list
            Node head = new Node(1);
            head.next = new Node(2);
            head.next.next = new Node(3);
            head.next.next.next = new Node(4);
            head.next.next.next.next = new Node(5);
            head.next.next.next.next.next = new Node(6);

            // Reverse linked list
            LinkedList list = new LinkedList();
            head = list.reverse_list(head);

            // Print reversed linked list
            Node current = head;
            while (current != null)
            {
                Console.Write(current.val + " ");
                current = current.next;
            }
            Console.ReadLine();
        }
    }
}
