namespace Morpion 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creer une nouvelle instance du jeu
            Game game = new Game();
            game.AfficherTableau();

            // boucle du jeu tant qu'on joue
            while (!game.AGagner()) {
                Console.WriteLine($"C'est le tour du joueur {game.RecupererJoueur()} - Entre la ligne");
                int ligne = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Entre maintenant la colonne");
                int colonne = int.Parse(Console.ReadLine()!);

                // placer le pion
                game.PlacerPion(ligne, colonne, game.RecupererJoueur());

                game.AfficherTableau();
                game.ChangerJoueur();
            }

        }
    }
}