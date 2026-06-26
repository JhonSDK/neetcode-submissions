public class ListNode{
    public int val;
    public ListNode prev;
    public ListNode next;
    public ListNode(int val){
        this.val = val;
        this.prev = prev;
        this.next = next;
    }
}

public class MyLinkedList {
    private ListNode head;
    private ListNode tail;

    public MyLinkedList() {
        head = new ListNode(0);
        tail = new ListNode(0);
        head.next = tail;
        tail.prev = head;
    }
    
    public int Get(int index) {
        ListNode cur = head.next;

        while(cur != null && index > 0){
            cur = cur.next;
            index--;
        }
        if(cur != null && cur != tail && index == 0){
            return cur.val;
        }
        return -1;
    }
    
    public void AddAtHead(int val) {
        ListNode node = new ListNode(val);
        ListNode next = head.next;
        ListNode prev = head;
        prev.next = node;
        next.prev = node;
        node.next = next;
        node.prev = prev;
    }
    
    public void AddAtTail(int val) {
        ListNode node = new ListNode(val);
        ListNode next = tail;
        ListNode prev = tail.prev;
        prev.next = node;
        next.prev = node;
        node.next = next;
        node.prev = prev;
    }
    
    public void AddAtIndex(int index, int val) {
        ListNode cur = head.next;

        while(cur != null && index > 0){
            cur = cur.next;
            index--;
        }
        if(cur != null && index == 0){
            ListNode node = new ListNode(val);
            ListNode next = cur;
            ListNode prev = cur.prev;
            next.prev = node;
            prev.next = node;
            node.next = next;
            node.prev = prev;
        }
    }
    
    public void DeleteAtIndex(int index) {
                ListNode cur = head.next;

        while(cur != null && index > 0){
            cur = cur.next;
            index--;
        }
        if(cur != null && cur != tail && index == 0){
            ListNode next = cur.next;
            ListNode prev = cur.prev;
            next.prev = prev;
            prev.next = next;
        }
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