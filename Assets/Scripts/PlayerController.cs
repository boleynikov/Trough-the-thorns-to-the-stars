using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    CircleCollider2D circleCollider;
    public float movementX;
    public float speed = 5f;
    
    
    void Start()
    {
        circleCollider = GetComponent<CircleCollider2D>();
        rb = GetComponent<Rigidbody2D>();       
    }
    public void OnLeftZoneDown() {

        movementX = -1;
        Debug.Log("LeftTouch");
    }
    public void OnRightZoneDown() {

        movementX = 1;
        Debug.Log("RightTouch");
    }
    public void OnZoneUp() {
        movementX = 0;
    }
    void Update()
    {
        rb.velocity = new Vector2(movementX * speed, rb.velocity.y);
    }
}
