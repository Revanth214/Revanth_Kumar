package ExceptionHandling;

class InvalidAmountException extends RuntimeException{
	public InvalidAmountException(String message) {
		super(message);
	}
}

class BankAcc{
	private double balance;
	private String name;
	public BankAcc(double balance, String name) {
		this.balance=balance;
		this.name=name;
	}
	public void withdrawl(double amount) {
		if(amount<=0) {
			throw new InvalidAmountException("Withdrawl amount must be greater than zero");
		}
		if(amount>balance) {
			throw new InvalidAmountException("Insufficient balance");
		}
		balance-=amount;
		
		System.out.println("Withdrawl successful");
		System.out.println("Remaining Balance: "+ balance);
	}
}


public class UncheckedException {
	public static void main(String[] args) {
		BankAcc account=new BankAcc(50000, "Revanth");
		try {
			account.withdrawl(600);
		}
		catch(InvalidAmountException e) {
			System.out.println("Error: "+ e.getMessage());
		}
		finally {
			System.out.println("Cleaned Up");
		}
	}
}
