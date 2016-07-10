using UnityEngine;
using System.Collections;

public class GameGUI : MonoBehaviour {

    public void Awake()
    {
        GameSystem.instance.ChangeGameState(GameState.Main);
        SoundManager.instance.PlaySound(SoundType.MainBGM);
    }

    public void Update()
    {
        Debug.Log("GameGUI.Update() : " + GameSystem.instance.gameState.ToString());
    }
}
