
public class Devinette extends Indice {
	
	public Devinette(int chiffre) {
		
	identifiant = "DXXXX";
	description = "Je suis l'astre perdu, la lumi�re �gar�e. Si vous voulez sortir, il vous faut me trouver. Moi";
	switch (chiffre) {
	case 0 : description += " qui fait les dizaines, centaines et milliers.";
	case 1 : description += " qui ne suis pas bien grand mais qui fait toute arm�e.";
	case 2 : description += ", pair hors-pair et premier des premiers.";
	case 3 : description += " qui compte ce qui fut, sera, et ce qui est.";
	case 4 : description += " qui, des �l�ments aux saisons, veux tout carr�.";
	case 5 : description += " qui vous aide d'une main � compter.";
	case 6 : description += ", ce sens occulte que vous ne pouvez utiliser.";
	case 7 : description += ", chiffre magique, de vertus et de p�ch�s.";
	case 8 : description += ", acrobate, sans �gal pour faire le poirier.";
	case 9 : description += ", un peu � l'ouest mais plus grande des unit�s.";
	}
	
	}

}
