using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject enemy;
    public GameObject player;
    public GameObject bullet;

    public int enemyCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    public bool defeat = false;
    public bool playerDown = false;
    public bool keyDown = false;

    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    void Update()
    {
        if (playerDown == true && defeat == false)
        {
            gameObject.GetComponent<AudioSource>().Play();
            defeat = true;
        }

        if (defeat == false && Input.GetButtonDown("Fire1") && keyDown == false)
        {
            keyDown = true;
            Instantiate(bullet, bullet.transform.position, bullet.transform.rotation);
        }

        if (Input.GetButtonUp("Fire1"))
            keyDown = false;
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);

        while (defeat == false)
        {
            for (int i = 0; i < enemyCount; i++)
            {
                GameObject newEnemy = (GameObject)Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);
                EnemyController enemyController = newEnemy.GetComponent<EnemyController>();
                enemyController.system = this.gameObject;               
                
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
}
