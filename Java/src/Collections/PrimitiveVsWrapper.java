package Collections;
import java.util.ArrayList;
public class PrimitiveVsWrapper {

	public static void main(String[] args) {
		int score=100;
		Integer wrapperScore=500;
		Integer a=score;
		int b=wrapperScore;
		System.out.println("Primitive: "+ score);
		System.out.println("Primitive: "+ b);
		System.out.println("Non-Primitive: "+ wrapperScore);
		System.out.println("Non-Primitive: "+ a);
		
		ArrayList<Integer> scores=new ArrayList<>();
		scores.add(score);
		scores.add(wrapperScore);
		scores.add(900);
		
		for (Integer s: scores) {
			System.out.println("Scores: "+ s);
		}

	}

}
