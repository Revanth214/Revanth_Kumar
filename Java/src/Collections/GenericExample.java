package Collections;

class LootBox<T>{
	T value;
	
	void setValue(T value) {
		this.value=value;
	}
	T getValue() {
		return value;
	}
}

public class GenericExample {

	public static void main(String[] args) {
		
		LootBox<String> playerName=new LootBox<>();
		playerName.setValue("Spark NEO");
		System.out.println("Player Name: "+playerName.getValue());
		
		LootBox<Integer> health=new LootBox<>();
		health.setValue(500);
		System.out.println("Health: "+health.getValue());
		
	}

}
