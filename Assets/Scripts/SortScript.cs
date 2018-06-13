using System;
using UnityEngine;

public class SortScript : MonoBehaviour
{
    private void Start()
    {
        Player[] players = {
            new Player("Johan", 100, 200, 300), 
            new Player("Alex", 150, 250, 320),
            new Player("James", 250, 375, 150)
        };
        
        Predicate<Player> predicate = FindPlayers;

        var foundedPlayers = Array.FindAll(players, predicate);
        
        OutputFoundedPlayer(foundedPlayers);
    }

    private static bool FindPlayers(Player obj)
    {
        return obj.Coins >= 150;
    }

    private void OutputFoundedPlayer(Player[] players)
    {
        foreach (var player in players)
        {
            print(player.Name + " has " + player.Coins + " coins!");
        }
    }
}