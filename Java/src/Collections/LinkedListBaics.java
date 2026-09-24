package Collections;
import java.util.LinkedList;
public class LinkedListBaics {
	public static void main(String[] args) {
		LinkedList<String> lst=new LinkedList<>();
		lst.add("Prepare repost");
		lst.add("Attend meeting");
		lst.add("Review code");
		
		for(String s:lst) {
			System.out.println(s);
		}
		System.out.println("=====================");
		lst.addFirst("Urgent: Fix production issue");
		lst.addLast("Submit report");
		
		for(String a:lst) {
			System.out.println(a);
		}
		System.out.println("=====================");
		
		lst.removeFirst();
		lst.removeLast();
		
		for(String a:lst) {
			System.out.println(a);
		}
		System.out.println("=====================");
		System.out.println(lst.get(0));
		lst.addFirst("Urgent: Fix production issue");
		System.out.println(lst.getFirst());
		lst.addLast("Submit Report");
		System.out.println(lst.getLast());
	}
}
