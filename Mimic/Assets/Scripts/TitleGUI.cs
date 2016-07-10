using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

public class TitleGUI : MonoBehaviour {

    public void Awake()
    {
        GameSystem.instance.ChangeGameState(GameState.Title);
        SoundManager.instance.PlaySound(SoundType.TitleBGM);
    }
    
    public void startBtnClick()
    {
        float length = SoundManager.instance.PlaySound(SoundType.ButtonClick);
        StartCoroutine(changeScene(length));
    }

    public IEnumerator changeScene(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(1);
    }

    public void Update()
    {
        Debug.Log("TitleGUi.Update() : " + GameSystem.instance.gameState.ToString());
    }
}
