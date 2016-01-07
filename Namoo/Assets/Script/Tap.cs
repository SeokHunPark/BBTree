using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tap : MonoBehaviour {

    GameSystem sys;

	// Use this for initialization
	void Start () {
        sys = GetComponentInParent<GameSystem>();
    }
	
	// Update is called once per frame
	void Update () {

        if(Input.GetMouseButtonDown(0) && Input.mousePosition.x > 190)
        {
            sys.berry += sys.berryIncome;
            sys.TextUpdate();
        }
	
	}
}
