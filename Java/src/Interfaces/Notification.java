package Interfaces;

public interface Notification {
	void send(String message);
}

class EmailAddress implements Notification{
	public String emailAddress;
	public EmailAddress(String email) {
		emailAddress=email;
	}
	@Override
	public void send(String message) {
		System.out.println("===Email Address===========");
		System.out.println("Sending email to: "+ emailAddress);
		System.out.println("Message: "+ message);
	}
}
class SmsAlert implements Notification{
	public String phoneNumber;
	public SmsAlert(String phoneNumber) {
		this.phoneNumber=phoneNumber;
	}
	@Override
	public void send(String message) {
		System.out.println("==========SMS Alert==========");
		System.out.println("Sending SMS: "+ phoneNumber);
		System.out.println("Message: "+ message);
	}
}