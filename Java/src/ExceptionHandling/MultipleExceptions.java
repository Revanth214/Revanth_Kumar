package ExceptionHandling;

public class MultipleExceptions {
	public static void main(String[] args) {
		try {
			int results=10/0;			
		}
		catch(ArithmeticException e) {
			System.out.println("Cannot divide by Zero");
		}
		catch(Exception e) {
			System.out.println("Some other exception");
		}
	}
}
