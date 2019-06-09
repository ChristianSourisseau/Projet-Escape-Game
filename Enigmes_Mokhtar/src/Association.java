
public class Association extends Indice {
	
	static String identifiant;
	
	public Association(int Prem, int Deux, int Trois, int Quatr, int type) {
		if (type==1) identifiant = "A" + Prem + Deux + Trois + Quatr;
		else identifiant = "B" + Prem + Deux + Trois + Quatr;
		description = "Un bout de papier où ont été dessinés des indices. Peut-être qu'avec un deuxième...";
	}

}
