import java.util.ArrayList;
import java.util.Random;

public class Salle {

	private static ArrayList<Obstacle> enigmes;
	private static ArrayList<Objet> objets;
	
	public Salle (int tailleSalle) {
		
		enigmes = new ArrayList<Obstacle>();
		
		enigmes.add(new Serrure());
		
		Random rand = new Random();
		
		for (int i=0; i < rand.nextInt(6); i++) {
			switch (rand.nextInt(2)) {
			case 0 : enigmes.add(new Combinaison()); break;
			case 1 : enigmes.add(new Serrure()); break;
			}
		}
		
		for (Obstacle obs : enigmes) {
			if (enigmes.indexOf(obs) < enigmes.size()-1) {
				for (Indice ind : obs.indices) {
					int current = enigmes.indexOf(obs) + 1;
					enigmes.get(rand.nextInt((enigmes.size() - current) + 1) + current).recompenses.add(ind);
				}
			}
		}
		
		for (Indice ind : enigmes.get(enigmes.size()-1).indices) {
			objets.add(ind);
		}
		
		
	}
	
	
}
