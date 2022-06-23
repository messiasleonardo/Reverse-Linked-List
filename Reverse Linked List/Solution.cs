namespace Reverse_Linked_List
{
    public class Solution
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;

            while (head != null)
            {
                ListNode next_node = head.next;
                head.next = prev;
                prev = head;
                head = next_node;
            }

            return prev;
        }
    }
}