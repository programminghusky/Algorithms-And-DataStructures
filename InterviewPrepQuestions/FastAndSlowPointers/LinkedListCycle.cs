/* Given the head of a Singly LinkedList, write a function to determine if the LinkedList has a cycle in it or not.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.FastAndSlowPointers
{
    class ListNode
    {
        public int Value = 0;
        public ListNode Next;

        public ListNode(int value)
        {
            Value = value;
        }
    }

    class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while(fast !=null && fast.Next!=null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
                if (slow == fast)
                    return true;
            }
            return false;
        }
    }
}
