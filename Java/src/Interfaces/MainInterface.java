package Interfaces;

public class MainInterface {

	public static void main(String[] args) {
		Notification obj=new EmailAddress("abc@gmail.com");
		obj.send("Your order has been shipped");
		Notification sms=new SmsAlert("+919002333432");
		sms.send("Your order has been shipped");
	}
	

}
