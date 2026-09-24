package Multiple_Inheritance;


interface Controllable{
	void turnOn();
	void turnOff();
}
interface Schedulable{
	void schedule(String time);
}

class SmartLight implements Controllable, Schedulable{
	public String brand;
	public int room;
	public SmartLight(String brand, int roomnumber) {
		this.brand=brand;
		room=roomnumber;
	}
	public void turnOn() {
		System.out.println("Turn ON");
	}
	public void turnOff() {
		System.out.println("Turn OFF");
	}
	public void schedule(String time) {
		System.out.println("Schedule Time: "+ time);
	}
}

public class Smart_Home_Device {
	public static void main(String[] args) {
//		SmartLight obj=new SmartLight("CR7", 103);
//		obj.turnOn();
//		obj.schedule("7:30");
//		obj.turnOff();
		Controllable ctrl=new SmartLight("CR7", 103);
		ctrl.turnOn();
		ctrl.turnOff();
		Schedulable obj=new SmartLight("Pixel", 105);
		obj.schedule("5:00 AM");
	}

}
