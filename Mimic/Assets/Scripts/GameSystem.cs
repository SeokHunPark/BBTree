using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum GameState
{
    None    = 0,
    Title   = 1,
    Main    = 2,
    Compose = 3,
    Max,
}

public class GameSystem
{
    public GameState gameState = GameState.None;

    private static GameSystem _instance;
    public static GameSystem instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameSystem();
            }
            return _instance;
        }
    }

    public void ChangeGameState(GameState state)
    {
        gameState = state;
    }
}
