public class ListNode {
    public string val;
    public ListNode prev;
    public ListNode next;
    public ListNode(string val) {
        this.val = val;
        prev = null;
        next = null;
    }
}

public class BrowserHistory {
    public ListNode page;

    public BrowserHistory(string homepage) {
        page = new ListNode(homepage);
        page.prev = null;
        page.next = null;
    }
    
    public void Visit(string url) {
        ListNode newSite = new ListNode(url);
        newSite.prev = page;
        page.next = newSite;
        page = newSite;
    }
    
    public string Back(int steps) {
        int counter = 0;
        while ((page.prev != null) && (steps > 0)) {
            page = page.prev;
            steps--;
        }
        return page.val;
    }
    
    public string Forward(int steps) {
        while ((page.next != null) && (steps > 0)) {
            page = page.next;
            steps--;
        }
        return page.val;
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */