
public class Association extends Indice {
	
	static String identifiant;
	
	public Association(int Prem, int Deux, int Trois, int Quatr, int type) {
		if (type==1) identifiant = "A" + Prem + Deux + Trois + Quatr;
		else identifiant = "B" + Prem + Deux + Trois + Quatr;
		description = "Un bout de papier o� ont �t� dessin�s des indices. Peut-�tre qu'avec un deuxi�me...";
	}

}
