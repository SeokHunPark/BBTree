using UnityEngine;
using System.Collections;

public enum SoundType
{
    None        = 0,
    TitleBGM,
    MainBGM,
    ButtonClick,
    Max,
}

public class SoundManager : ScriptableObject {

    private static SoundManager _instance = null;
    public static SoundManager instance
    {
        get
        {
            if (_instance == null)
                _instance = ScriptableObject.CreateInstance<SoundManager>();

            return _instance;
        }
    }

    public float PlaySound(SoundType type)
    {
        string soundPath = "Sound/" + type.ToString();

        GameObject go = new GameObject();
        AudioSource source = go.AddComponent<AudioSource>();
        source.clip = Resources.Load(soundPath) as AudioClip;
        if (source.clip == null)
        {
            Debug.Log("No Such Sound File Path : " + soundPath);
            return 0;
        }

        source.Play();
        Destroy(go, source.clip.length);

        return source.clip.length;
    }
}
