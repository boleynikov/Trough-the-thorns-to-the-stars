using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Increase : MonoBehaviour
{
    public GameObject enemy;
    private void Start()
    {
        StartCoroutine(IncreaseSpeed());
    }
    void Reincrease()
    {
        StartCoroutine(IncreaseSpeed());
    }
    IEnumerator IncreaseSpeed()
    {
        yield return new WaitForSeconds(5f);
        enemy.GetComponent<Rigidbody2D>().gravityScale += 0.2f;
        Reincrease();
    }
}
