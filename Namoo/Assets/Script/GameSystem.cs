using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameSystem : MonoBehaviour {

    public int level;
    public int berry;
    public float gold;
    public int berryIncome;
    public float growupPrice;

    public GameObject trunk;
    public GameObject newBerry;

    public Text goldTxt;
    public Text growUpTxt;
    public Text berryIncomeTxt;
    public Text berryTxt;

	// Use this for initialization
	void Start () {
        gold = 0;
        level = 1;
        berryIncome = 1;
        growupPrice = 10;

        Instantiate(newBerry, new Vector3(0.35f, trunk.transform.position.y, -1), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void TextUpdate()
    {
        goldTxt.text = "금화 : " + gold + "G";
        berryIncomeTxt.text = "수확량 : " + berryIncome + "개";
        berryTxt.text = "열매 : " + berry + "개";
    }
}
