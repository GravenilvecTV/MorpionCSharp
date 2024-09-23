namespace Morpion 
{

    public class Game {

        // creer la grille de jeu 3x3
        char[,] tableau = new char[3, 3];

        // une variable joueur actuel
        char joueurActuel = 'X';

        bool aGagner = false;

        public char RecupererJoueur () {
            return joueurActuel;
        }

        public bool DetecterVictoire (int x, int y, char symbol) {

            // verifier de droite à gauche (horizontal)
            int count = 0;
            for (int i = 0; i < 3; i++) {
                if (tableau[x, i] == symbol) {
                    count++;
                }
            }
            if (count == 3) {
                Console.WriteLine($"Le joueur {symbol} a gagné horizontalement");
                aGagner = true;
                return aGagner;
            }

            // verifier de haut en bas (verticalement)
            count = 0;
            for (int i = 0; i < 3; i++) {
                if (tableau[i, x] == symbol) {
                    count++;
                }
            }
            if (count == 3) {
                Console.WriteLine($"Le joueur {symbol} a gagné verticalement");
                aGagner = true;
            }

            // verifier diagonal
            count = 0;
            for (int i = 0; i < 3; i++) {
                if (tableau[i, i] == symbol) {
                    count++;
                }
            }
            if (count == 3) {
                Console.WriteLine($"Le joueur {symbol} a gagné diagonnal");
                aGagner = true;
            }


            // verifier diagonal autre
            count = 0;
            for (int i = 0; i < 3; i++) {
                if (tableau[i, 2-i] == symbol) {
                    count++;
                }
            }
            if (count == 3) {
                Console.WriteLine($"Le joueur {symbol} a gagné diagonnal");
                aGagner = true;
            }


            return false;
        }

        public bool AGagner() {
            return aGagner;
        }

        public void ChangerJoueur() {
            if (joueurActuel == 'X') {
                joueurActuel = '0';
            } else {
                joueurActuel = 'X';
            }
        }

        // une fonction pour placer un pion dans la grille
        public void PlacerPion(int x, int y, char symbol) {
            tableau[x, y] = symbol;

            DetecterVictoire(x, y, symbol);
        }

        // une premiere fonction pour afficher cette grille de jeu
        public void AfficherTableau() {
            // parcourir chaque colonne
            for (int i = 0; i < 3; i++) {
                // parcour chaque ligne
                for (int j = 0; j < 3; j++) {
                    // variable pour recuperer la case actuel
                    char position = tableau[i, j];
                    if (position == '\0') {
                        Console.Write('.');
                    } else {
                        Console.Write(position);
                    }
                }
                Console.WriteLine();
            }
        }

    }

}