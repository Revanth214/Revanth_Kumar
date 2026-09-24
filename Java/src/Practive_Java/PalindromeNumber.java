package Practive_Java;
import java.util.*;

public class PalindromeNumber {
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Scanner s=new Scanner(System.in);
		System.out.println("Enter a number");
		int num=s.nextInt();
		int temp=num;
		int rev=0;
		while(temp!=0) {
			int rem=temp%10;
			rev=rev*10+rem;
			temp=temp/10;
		}
		if(rev==num) {
			System.out.println(num+" is a palindrome");
		}
		else {
			System.out.println(num+ " is not a palindrom");
		}
	}
}
