package Abstraction;

public class CreditCardPayment extends Payment{
	public int cardLastFourDigits;
	public CreditCardPayment(String name, double amount, int cardnumber) {
		super(name, amount);
		cardLastFourDigits=cardnumber;
	}
	@Override
	public void processPayment() {
		System.out.println("Processing credit card payment..........");
	}
}
