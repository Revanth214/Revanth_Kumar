package Inheritance;

public class GameAccount {
	public String username;
	public int level;
	public GameAccount(String username, int level) {
		this.username=username;
		this.level=level;
	}
	public void displayAccount() {
		System.out.println("=====Account Details======");
		System.out.println("User Name: "+ username);
		System.out.println("Level: "+ level);
	}
}
