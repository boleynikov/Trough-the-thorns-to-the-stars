using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementX;
    public float speed = 5f;

    public GameObject restartBtnObject;
    public GameObject exitBtnObject;
    public GameObject pauseRtnObject;
    public GameObject panel;

    Rigidbody2D rb;
    CircleCollider2D circleCollider;

    
    
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Enemy")
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            restartBtnObject.SetActive(true);
            exitBtnObject.SetActive(true);
            panel.SetActive(true);
            pauseRtnObject.SetActive(false);
        }
    }
}
