using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2spawn : MonoBehaviour
{
    public GameObject Enemy2Prefab;
    public float respawnTime = 3.0f;
    private Vector2 screenBounds;


    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(enemyWave());
    }
    private void spawnEnemy()
    {
        GameObject a = Instantiate(Enemy2Prefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y + 10);
    }
    IEnumerator enemyWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}