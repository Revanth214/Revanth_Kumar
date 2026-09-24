package Practive_Java;
import java.util.*;
public class RecursiveFact {
	public static int calculateFactorial(int n) {
		if(n==0 || n==1){
			return 1;
		}
		return n*calculateFactorial(n-1);
	}
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s=new Scanner(System.in);
		System.out.println("Enter a number: ");
		int num=s.nextInt();
		int result=calculateFactorial(num);
		System.out.println("The factorial of "+ num + " is: "+ result);
	}

}
