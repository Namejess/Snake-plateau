using JeuxSerpent.utils;
using System;

class Program
{
           
    private static void Main(string[] args)
    {
        Console.WriteLine("Bienvenue dans le jeux du serpent de Vincent REMY");
        initGame();
    }
    
    private static void initGame()
    {
        Console.WriteLine("Veuillez saisir la taille du plateau de jeu");
        int boardLength = Convert.ToInt32(Console.ReadLine());
        List<Player> players = askAllPlayersInformation();
        SnakeBoard board = new SnakeBoard(boardLength, players);
        board.startGame();
    }
    
    private static List<Player> askAllPlayersInformation()
    {
        List<Player> players = new List<Player>();
        int playerCount = askPlayerNumbers();
        for (int i = 0; i < playerCount; i++)
            players.Add(askOnePlayerInformation(i));
        return players;
    }
    private static Player askOnePlayerInformation(int numberPlayer)
    {
        Console.WriteLine("Veuillez entrer le nom du joueur " + (numberPlayer  + 1));
        string playerName = Console.ReadLine() ?? "player" + numberPlayer;
        return new Player(playerName);
    }
    
    private static int askPlayerNumbers()
    {
        Console.WriteLine("Combien de joueur êtes-vous ?");
        return Convert.ToInt32(Console.ReadLine());
    }
}