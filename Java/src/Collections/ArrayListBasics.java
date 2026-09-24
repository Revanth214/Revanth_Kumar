package Collections;
import java.util.ArrayList;

public class ArrayListBasics {
	
	public static void main(String[] args)
	{
		
		ArrayList<String> players=new ArrayList<>();
		players.add("Spark NEO");
		players.add("RB-LEO-517");
		players.add("Spark Rider");
		players.add("Spark Skanda");
		players.add("Spark Raju");
					
		for(String player:players)
			{
				System.out.println("Player Name: "+ player);
			}
		System.out.println("Number of Players: "+ players.size());
		
		System.out.println("First Player: "+players.get(0));
		System.out.println("Third Player: "+ players.get(2));
		
		players.set(1, "RB-LEO-999");
		players.remove(4);
		players.add("Spark Phantom");
		boolean check=players.contains("Spark NEO");
		System.out.println("Spark NEO exists: " + check);
		System.out.println("No of Players: "+ players.size());
		for(String player:players)
		{
			System.out.println("Player Name: "+ player);
		}
		
		for(String player: players) {
			if(player.equals("Spark Skanda")) {
				players.remove(player);
			}
		}
		for(String player:players)
		{
			System.out.println("Player Name: "+ player);
		}
	}
	
}
