using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void Restart()
    {
        Debug.Log("Restart");
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }
    
}
