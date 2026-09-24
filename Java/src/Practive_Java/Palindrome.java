package Practive_Java;
import java.util.*;
public class Palindrome {

	public static boolean isPalindrome(String str) {
		str=str.toLowerCase();
		
		if(str.length()==0 || str.length()==1) {
			return true;
		}
		if(str.charAt(0)==str.charAt(str.length()-1)) {
			return isPalindrome(str.substring(1,str.length()-1));
		}
		return false;
	}
	public static void main(String[] args) {
		// TODO Auto-generated method stub
				
		Scanner s=new Scanner(System.in);
		System.out.println("Enter a string: ");
		String str=s.next();
		System.out.println("Is '" + str + "' a palindrome? "+ isPalindrome(str));
		
	}

}
