using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed;

    public GameObject system;

    void Update()
    {
        GameController gameController = system.GetComponent<GameController>();

        if (gameController.defeat == false)
            transform.position -= new Vector3(moveSpeed, 0f, 0f);
    }

	void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GameController gameController = system.GetComponent<GameController>();
            gameController.playerDown = true;
            return;
        }

        if (other.tag == "Bullets")
        {
            moveSpeed = 0;
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();

            Destroy(other.gameObject);
            Destroy(gameObject.GetComponent<MeshRenderer>());
            Destroy(gameObject.GetComponent<BoxCollider>());
            Destroy(gameObject, 0.1f);
        }
    }
}
