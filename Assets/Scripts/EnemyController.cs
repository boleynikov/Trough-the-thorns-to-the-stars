using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 1f;
    }
    public void IncreaseSpeed(float increasing)
    {
        rb.gravityScale = increasing;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Destroyer")
        {
            Destroy(gameObject);
        }
    }
}
