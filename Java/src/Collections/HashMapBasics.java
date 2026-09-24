package Collections;
import java.util.HashMap;

public class HashMapBasics {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		HashMap<Integer, String> employees=new HashMap<Integer, String>();
		employees.put(1, "Rama");
		employees.put(2, "Krishna");
		employees.put(3,"Shiva");
		
		System.out.println("Employee: "+ employees.get(1));
	}

}
