using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public EnemyController enemyController;

    public Transform spawnPos;
    float spawnX;
    float spawnY;
    public GameObject fallingEnemy;
    
    void Start()
    {
        StartCoroutine(Spawn());
        spawnX = spawnPos.position.x;
        spawnY = spawnPos.position.y;       
    }
    void Respawn()
    {
        StartCoroutine(Spawn());       
    }    
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(1f);
        Instantiate(fallingEnemy, new Vector2(Random.Range(spawnX - 2.3f, spawnX + 2.4f), spawnY), Quaternion.identity);
        Respawn();
    }
    
}
