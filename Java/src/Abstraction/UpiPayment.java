package Abstraction;

public class UpiPayment extends Payment{
	public int upiID;
	public UpiPayment(String name, int amount, int upiID) {
		super(name, amount);
		this.upiID=upiID;
	}
	@Override
	public void processPayment() {
		System.out.println("Processing UPI payment................");
	}
}
