using UnityEngine;
using System.Collections;

public class UIButtonScale : MonoBehaviour {

    public float tweenScale = 0.05f;
    public UnityEngine.UI.Button button;

    private Vector2 now = new Vector2(1, 1);

    void Awake()
    {
        now = this.transform.localScale;
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            now = gameObject.transform.localScale;
            now.x -= now.x * tweenScale;
            now.y -= now.y * tweenScale;
            gameObject.transform.localScale = now;
        }
    }

    void OnMouseUp()
    {
        if (Input.GetMouseButtonUp(0))
        {
            now = gameObject.transform.localScale;
            now.x += now.x * tweenScale;
            now.y += now.y * tweenScale;
            gameObject.transform.localScale = now;
        }
    }

    public void OnClick()
    {
        now = gameObject.transform.localScale;
        now.x -= now.x * tweenScale;
        now.y -= now.y * tweenScale;
        gameObject.transform.localScale = now;
    }
}
