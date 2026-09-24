package constructors;
public class ConstructorOverloading {

	private static class Mobile{
		int year;
		String Model;
		String OS;
		public Mobile(int year, String model) {
			this.year=year;
			Model=model;
		}
		public Mobile(int year, String model, String os) {
			this.year=year;
			this.Model=model;
			this.OS=os;
		}
	}
	public static void main(String[] args) {
		Mobile m=new Mobile(2026, "Samsung Galaxy Z Fold 7");
		System.out.println("Year: "+ m.year);
		System.out.println("Model: "+ m.Model);
		System.out.println("==========Constructor Overloading==============");
		Mobile mobile=new Mobile(2024, "Samsung Galaxy S24","Google Android");
		System.out.println("Mobile Year: "+ mobile.year);
		System.out.println("Mobile Model: "+ mobile.Model);
		System.out.println("Operating System: "+ mobile.OS);
	}
}
