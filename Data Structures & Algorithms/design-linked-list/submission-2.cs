public class ListNode {
    public int val;
    public ListNode next;
    public ListNode prev;
    public ListNode(int val, ListNode next = null, ListNode prev = null) {
        this.val = val;
        this.next = next;
        this.prev = prev;
    }
}

public class MyLinkedList {
    private ListNode head;
    private ListNode tail;
    private int size;

    public MyLinkedList() {
        head = new ListNode(0);
        tail = new ListNode(0);
        head.next = tail;
        tail.prev = head;
        size = 0;
    }
    
    public int Get(int index) {
        if (index >= size) return -1;
        ListNode curr = head.next;
        for (int i = 0; i < index; i++) {
            curr = curr.next;
        }
        return curr.val;
    }
    
    public void AddAtHead(int val) {
        ListNode newNode = new ListNode(val);
        ListNode next = head.next;

        head.next = newNode;
        newNode.prev = head;
        newNode.next = next;
        next.prev = newNode;
        size++;
    }
    
    public void AddAtTail(int val) {
        ListNode newNode = new ListNode(val);
        ListNode prev = tail.prev;

        tail.prev = newNode;
        newNode.prev = prev;
        newNode.next = tail;
        prev.next = newNode;
        size++;
    }
    
    public void AddAtIndex(int index, int val) {
        if (index > size) return;
        ListNode newNode = new ListNode(val);
        ListNode curr = head.next;
        for (int i = 0; i < index; i++) {
            curr = curr.next;
        }
        ListNode prev = curr.prev;
        prev.next = newNode;
        newNode.prev = prev;
        newNode.next = curr;
        curr.prev = newNode;
        size++;
    }
    
    public void DeleteAtIndex(int index) {
        if (index >= size) return;
        ListNode curr = head.next;
        for (int i = 0; i < index; i++) {
            curr = curr.next;
        }
        ListNode prev = curr.prev;
        ListNode next = curr.next;
        prev.next = next;
        next.prev = prev;
        size--;
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */