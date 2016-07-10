using UnityEngine;
using System.Collections;

public class UIButton : MonoBehaviour {

    public delegate void OnClick();
    public OnClick onClick;

    private bool down = false;
	void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
            down = true;
    }

    void OnMouseUp()
    {
        if (Input.GetMouseButtonUp(0) && down)
        {
            down = false;
            onClick();
        }
    }
}
