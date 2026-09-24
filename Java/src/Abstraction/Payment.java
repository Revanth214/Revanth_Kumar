package Abstraction;

abstract class Payment {
	public String customerName;
	public double amount;
	public Payment(String name, double amount) {
		customerName=name;
		this.amount=amount;
	}
	public abstract void processPayment();
	public void showPaymentDetails() {
		System.out.println("==========Payment Details============");
		System.out.println("Customer Name: "+ customerName);
		System.out.println("Amount: "+ amount);
	}
}
