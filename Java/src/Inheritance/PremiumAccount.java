package Inheritance;

public class PremiumAccount extends GameAccount {
	public int subscriptionMonths;
	public PremiumAccount(String username, int level, int subscriptionMonths) {
		super(username,level);
		this.subscriptionMonths=subscriptionMonths;
	}
	
	@Override
	public void displayAccount() {
		super.displayAccount();
		System.out.println("Subscription Months: "+ subscriptionMonths);
	}
}
