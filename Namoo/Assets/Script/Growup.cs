using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Growup : MonoBehaviour {

    public GameObject trunk;
    public GameObject berry;

    public float costRate;

    GameSystem sys;

    Vector3 bPos;
    float bPosw;

	// Use this for initialization
	void Start () {
        bPosw = -1;
        bPos = new Vector3(0.35f, -2, -1);

        sys = GetComponentInParent<GameSystem>();
    }
	
    public void OnClick()
    {
        if (sys.growupPrice <= sys.gold)
        {
            sys.gold -= sys.growupPrice;

            trunk.transform.localScale += new Vector3(0, 0.5f, 0);
            trunk.transform.position += new Vector3(0, 0.5f, 0);
            bPos.y += 1f;
            bPos.x *= bPosw;

            sys.berryIncome++;
            sys.level++;
            sys.growupPrice *= costRate;
            
            sys.growUpTxt.text = "성장! (" + sys.growupPrice + "G)";

            sys.TextUpdate();

            Instantiate(berry, bPos, Quaternion.identity);
        }
    }
}
