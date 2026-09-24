package Inheritance;

public class Character {
	public String Name;
	public int Health;
	public int Level;
	
	public Character(String name, int health, int level) {
		Name=name;
		Health=health;
		Level=level;
	}
	public void displayInfo() {
		System.out.println("=======Character Information=======");
		System.out.println("Character Name: "+ Name);
		System.out.println("Health: "+ Health);
		System.out.println("Player Level: "+Level);
	}
}


