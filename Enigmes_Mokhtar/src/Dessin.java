
public class Dessin extends Indice {

	public Dessin(int Prem, int Deux, int Trois, int Quatr) {
		identifiant = "Dessin";
		description = "Un coloriage simple, sans doute de la main d'un enfant : c'est une maison, ";
		if (Prem>0) description += "un arbre � "+ Prem +" pommes,";
		if (Deux>0) description += Deux +" bosquets,";
		if (Trois>0) description += Trois +" poissons dans une mare,";
		if (Quatr>0) description += Quatr +" �toiles dans le ciel,";
		description += "et rien d'autre de tr�s important.";
	}
	
}
