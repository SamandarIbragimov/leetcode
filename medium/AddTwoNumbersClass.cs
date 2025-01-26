using leetcode.helper;

namespace leetcode.medium
{
    public class AddTwoNumbersClass
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
        {
            ListNode dummyHead = new ListNode();
            ListNode current = dummyHead;
            int carry = 0;

            while (l1 != null || l2 != null || carry != 0)
            {
                int val1 = (l1 != null) ? l1.val : 0;
                int val2 = (l2 != null) ? l2.val : 0;

                int sum = val1 + val2 + carry;
                carry = sum / 10;
                current.next = new ListNode(sum % 10);
                current = current.next;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }

            return dummyHead.next;
        }
    }
}