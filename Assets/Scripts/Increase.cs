using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Increase : MonoBehaviour
{
    public GameObject enemy;
    public Text AsteroidSpeed;
    float increase = 0f;
    private void Start()
    {
        StartCoroutine(IncreaseSpeed());
    }
    void Reincrease()
    {
        StartCoroutine(IncreaseSpeed());
    }
    private void FixedUpdate()
    {
        increase += (float)System.Math.Ceiling(Time.deltaTime / 10);
        
    }
    IEnumerator IncreaseSpeed()
    {
        var speed = enemy.GetComponent<Rigidbody2D>().velocity;
        yield return new WaitForSeconds(5f);
        AsteroidSpeed.text = "Скорость астероидов " + increase + " св.л./час";
        speed = new Vector2(speed.x, speed.y + increase);
        Reincrease();
    }
}
