package Inheritance;

public class Mage extends Character {
	public int mana;
	public String spellPower;
	
	public Mage(String name, int health, int level, int mana, String spell) {
		super(name, health, level);
		this.mana=mana;
		spellPower=spell;
	}
	
	@Override
	public void displayInfo() {
		super.displayInfo();
		System.out.println("Mana: "+ mana);
		System.out.println("Spell power: "+ spellPower);
	}
}
