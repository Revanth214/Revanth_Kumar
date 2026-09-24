package Inheritance;

public class EliteAccount extends PremiumAccount {
	public int rank;
	public int specialPerks;
	public EliteAccount(String username, int level, int subscriptionMonths, int rank, int specialPerks) {
		super(username, level, subscriptionMonths);
		this.rank=rank;
		this.specialPerks=specialPerks;
	}
	@Override
	public void displayAccount() {
		super.displayAccount();
		System.out.println("Rank: "+ rank);
		System.out.println("Special Perks: "+ specialPerks);
	}
}
