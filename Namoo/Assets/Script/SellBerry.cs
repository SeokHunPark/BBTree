using UnityEngine;
using System.Collections;

public class SellBerry : MonoBehaviour {

    GameSystem sys;

    // Use this for initialization
    void Start()
    {
        sys = GetComponentInParent<GameSystem>();
    }

    public void OnClick()
    {
        sys.gold += sys.berry;
        sys.berry = 0;

        sys.TextUpdate();
    }
}
