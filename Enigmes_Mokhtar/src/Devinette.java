
public class Devinette extends Indice {
	
	public Devinette(int chiffre) {
		
	identifiant = "DXXXX";
	description = "Je suis l'astre perdu, la lumière égarée. Si vous voulez sortir, il vous faut me trouver. Moi";
	switch (chiffre) {
	case 0 : description += " qui fait les dizaines, centaines et milliers.";
	case 1 : description += " qui ne suis pas bien grand mais qui fait toute armée.";
	case 2 : description += ", pair hors-pair et premier des premiers.";
	case 3 : description += " qui compte ce qui fut, sera, et ce qui est.";
	case 4 : description += " qui, des éléments aux saisons, veux tout carré.";
	case 5 : description += " qui vous aide d'une main à compter.";
	case 6 : description += ", ce sens occulte que vous ne pouvez utiliser.";
	case 7 : description += ", chiffre magique, de vertus et de péchés.";
	case 8 : description += ", acrobate, sans égal pour faire le poirier.";
	case 9 : description += ", un peu à l'ouest mais plus grande des unités.";
	}
	
	}

}
