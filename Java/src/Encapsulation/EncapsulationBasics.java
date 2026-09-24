package Encapsulation;

public class EncapsulationBasics {

	public static void main(String[] args) {
		Bank_App ba=new Bank_App();
		ba.setSalary(500000);
		double result=ba.getSalary();
		System.out.println("Balance: "+ result);
	}
}
