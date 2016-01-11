using UnityEngine;
using System.Collections;

public class MoveBullets : MonoBehaviour
{
    public float bulletSpeed;
	
	// Update is called once per frame
	void Update ()
    {
        transform.position += new Vector3(bulletSpeed, 0f, 0f);

        if(transform.position.x >= 16)
            Destroy(gameObject);
	}
}
