import java.util.Random;

public class Combinaison extends Obstacle {
	
	int Prem;
	int Deux;
	int Trois;
	int Quatr;
	int Myst;
	
	public Combinaison() {
		Random rand = new Random();
		int num = rand.nextInt(10);
		switch (num) {
		case 0 : Prem=3;Deux=5;Trois=8;Quatr=2;Myst=5;
		case 1 : Prem=1;Deux=3;Trois=3;Quatr=7;Myst=7;
		case 2 : Prem=5;Deux=1;Trois=6;Quatr=3;Myst=1;
		case 3 : Prem=2;Deux=0;Trois=1;Quatr=9;Myst=9;
		case 4 : Prem=2;Deux=4;Trois=1;Quatr=1;Myst=2;
		case 5 : Prem=3;Deux=1;Trois=0;Quatr=5;Myst=0;
		case 6 : Prem=9;Deux=4;Trois=0;Quatr=6;Myst=6;
		case 7 : Prem=7;Deux=5;Trois=8;Quatr=4;Myst=8;
		case 8 : Prem=0;Deux=5;Trois=6;Quatr=4;Myst=4;
		case 9 : Prem=6;Deux=7;Trois=2;Quatr=3;Myst=3;
		}
		int ind = rand.nextInt(4);
		switch (ind) {
		case 0 : creerDessin();
		case 1 : creerSudoku();
		case 2 : creerAssociation();
		case 3 : creerCodag();
		}
	}
	
	public boolean verifComb (int Prem, int Deux, int Trois, int Quatr) {
		return (Prem==this.Prem && Deux==this.Deux && Trois==this.Trois && Quatr==this.Quatr);
	}
	
	public void creerDessin() {
		indices.add(new Dessin(Prem, Deux, Trois, Quatr));
	}
	
	public void creerSudoku() {
		indices.add(new Sudoku(Prem, Deux, Trois, Quatr));
	}
	
	public void creerCodag() {
		indices.add(new Codag(Prem, Deux, Trois, Quatr));
	}
	
	public void creerAssociation() {
		indices.add(new Association(Prem, Deux, Trois, Quatr, 1));
		indices.add(new Association(Prem, Deux, Trois, Quatr, 0));
		indices.add(new Devinette(Myst));
	}
	
	
}
