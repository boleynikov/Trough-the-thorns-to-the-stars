using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCount : MonoBehaviour
{
    bool isRun;
    public float points = 0;

    public Text pointText;
    void Start()
    {
        if (Time.timeScale == 0f)
            isRun = false;
        else
            isRun = true;
    }
    void Update()
    {
        pointText.text = points + " св.лет";
    }
    void FixedUpdate()
    {
        if (isRun)
        {
            points++;
        }
    }
}
