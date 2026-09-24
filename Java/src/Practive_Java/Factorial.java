package Practive_Java;
import java.io.*;
import java.util.*;

public class Factorial {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s=new Scanner(System.in);
		System.out.println("Enter a value: ");
		int a=s.nextInt();
		int temp=1;
		for(int i=a; i>0;i--) {
			temp*=i;
		}
		System.out.println("Factorial Value of " +a+ "is: " + temp);
	}

}