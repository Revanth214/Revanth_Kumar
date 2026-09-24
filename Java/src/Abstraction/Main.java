package Abstraction;

public class Main {

	public static void main(String[] args) {
		Payment pay=new UpiPayment("Revanth", 1000000,1234);
		Payment pytm=new CreditCardPayment("Bharath", 50000, 34251);
		
		pay.showPaymentDetails();
		pay.processPayment();
		pytm.showPaymentDetails();
		pytm.processPayment();
		

	}

}
