package Inheritance;

public class Game {
	public static void main(String[] args) {
		//ProPlayer obj=new ProPlayer("Spark NEO");
		//obj.Display();
		//obj.Displayyyy();
		
		Character obj=new Mage("Spark NEO", 150, 69, 24,"magic");
		obj.displayInfo();
		
		GameAccount pa=new PremiumAccount("RB-LEO", 67, 3);
		pa.displayAccount();
		GameAccount EA=new EliteAccount("Revanth BHAI", 58, 5, 98, 100);
		EA.displayAccount();
	}
}
