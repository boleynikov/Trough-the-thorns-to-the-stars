using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PauseButton : MonoBehaviour
{
    public GameObject panel;
    public GameObject restartBtnObject;
    public GameObject exitBtnObject;
    public void Pause()
    {
        Time.timeScale = Time.timeScale == 1f ? 0f : 1f; 
        panel.SetActive(!panel.activeSelf);
        restartBtnObject.SetActive(!restartBtnObject.activeSelf);
        exitBtnObject.SetActive(!exitBtnObject.activeSelf);
    }
}
