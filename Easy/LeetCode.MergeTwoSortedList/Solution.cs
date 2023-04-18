using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MergeTwoSortedList
{
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            List<int> mergedList = new();
            ListNode nextNode = null;

            if (list1 != null)
            {
                mergedList.Add(list1.val);
                nextNode = list1.next;

                while (nextNode != null)
                {
                    mergedList.Add(nextNode.val);
                    nextNode = nextNode.next;
                }
            }

            if (list2 != null)
            {
                mergedList.Add(list2.val);

                nextNode = list2.next;

                while (nextNode != null)
                {
                    mergedList.Add(nextNode.val);
                    nextNode = nextNode.next;
                }
            }

            mergedList.Sort();
            ListNode actualNode = null;
            ListNode previousNode = null;

            for (int i = mergedList.Count - 1; i >= 0; i--)
            {
                if (previousNode == null)
                {
                    actualNode = new(mergedList[i]);
                    previousNode = actualNode;
                    continue;
                }
                actualNode = new(mergedList[i], previousNode);
                previousNode = actualNode;
            }

            return actualNode;
        }
    }

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
}
