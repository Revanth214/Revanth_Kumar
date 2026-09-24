package constructors;

public class ConstructorBasics {

	private int x;
	public ConstructorBasics() {
		x=5;
		System.out.println(x);
	}
	
	public static void main(String[] args) {
		ConstructorBasics obj=new ConstructorBasics();
		System.out.println(obj.x);
		
		
	}
}
