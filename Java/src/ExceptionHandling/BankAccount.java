package ExceptionHandling;
public class BankAccount {
	public static void main(String[] args) {
		Main account=new Main(5000, "Revanth");
		try {
			account.Withdrawl(2000);
			account.Withdrawl(4000);
		}
		catch(InsufficientBalanceException e) {
			System.out.println("Error: "+e.getMessage());
		}
	}
}

class Main{
	private double balance;
	private String name;
	public Main(double balance, String name) {
		this.balance=balance;
		this.name=name;
	}
	
	public void Withdrawl(double amount) throws InsufficientBalanceException {
		if(amount<=0) {
			throw new InsufficientBalanceException("Withdrawl amount must be greater than zero");
		}
		if(balance<amount) {
			throw new InsufficientBalanceException("Insufficient balance");
		}
		balance=balance-amount;
		
		System.out.println("Withdrawl successful");
		System.out.println("Remaining Balance: "+ balance);
	}
}
class InsufficientBalanceException extends Exception{
	public InsufficientBalanceException(String message) {
		super(message);
	}
	
}
